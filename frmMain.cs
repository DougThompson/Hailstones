/*
Copyright (c) 2012 Doug Thompson

Permission is hereby granted, free of charge, to any person obtaining a
copy of this software and associated documentation files (the
"Software"),to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be included
in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hailstones
{
	public partial class frmMain : Form
	{
		// Set the Hailstone collection as global to allow for different graph types
		List<Hailstone> hailstones;
	
		// Simple structure to represent a Hailstone
		public struct Hailstone
		{
			public int number;
			public int trips;
			public int max;
		}

		public frmMain()
		{
			InitializeComponent();

			// Set the first graph type as the default
			ddlPlotType.SelectedIndex = 0;
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			// Depending on the number range selected, this could be a long process
			// so set the cursor to wait
			this.Cursor = Cursors.WaitCursor;

			// Set the starting values and objects
			int currentNumber, startRange, endRange, currentMax;
			hailstones = new List<Hailstone>();
			startRange = int.Parse(tbxStart.Text);
			endRange = int.Parse(tbxEnd.Text);

			if (startRange > endRange)
			{
				// For fun, use an XOR swap
				startRange ^= endRange;
				endRange ^= startRange;
				startRange ^= endRange;

				tbxStart.Text = startRange.ToString();
				tbxEnd.Text = endRange.ToString();
			}

			Hailstone hailstone;
			for (currentNumber = startRange; currentNumber <= endRange; currentNumber++)
			{
				// Create a new Hailstone and set its starting values
				hailstone = new Hailstone();
				hailstone.number = currentNumber;
				hailstone.max = currentNumber;
				hailstone.trips = 1;
				currentMax = currentNumber;
				do
				{
					// Process the rules (even: n / 2, odd: n * 3 + 1)
					currentMax = (currentMax % 2 == 0) ? currentMax/2 : 3 * currentMax + 1;
					// Update maximum reached value
					hailstone.max = (currentMax > hailstone.max) ? currentMax : hailstone.max;
					// Increase trip count until 1 is reached
					hailstone.trips++;
				} while (currentMax > 1);

				// Add the new Hailstone to the collection
				hailstones.Add(hailstone);
				// Update the progress
				lblProgress.Text = String.Format("Processing: {0}", currentNumber);
				Application.DoEvents();
			}

			// Update the graph with the new values
			lblProgress.Text = "Building Graph...";
			Application.DoEvents();
			updateGraph();
			Application.DoEvents();

			// Output the values to a textbox, tab delimited
			StringBuilder output = new StringBuilder();
			foreach (Hailstone item in hailstones)
			{
				lblProgress.Text = String.Format("Adding {0} to output...", item.number);
				Application.DoEvents();
				output.Append(String.Format("Number:{0}\t\tTrips:{1}\t\tMax:{2}\r\n", item.number, item.trips, item.max));
			}
			tbxOut.Text = output.ToString();
			lblProgress.Text = "";

			this.Cursor = Cursors.Default;
		}

		private void updateGraph()
		{
			// Make sure we have some Hailstones to graph and then
			// plot them according to the selected graph type from the dropdown
			if (hailstones != null)
			{
				// Allow the user to select a maximum value
				// If it is -1, then do not use a maximum at all
				int maxValue = int.Parse(tbxMaxValue.Text);

				// Clear the points and begin populating
				chtResults.Series[0].Points.Clear();
				foreach (Hailstone item in hailstones)
				{
					if (ddlPlotType.SelectedIndex == 0)
					{
						if (item.max <= maxValue | maxValue == -1)
						{
							chtResults.Series[0].Points.Add(new DataPoint(item.number, item.max));
						}
					}
					else if (ddlPlotType.SelectedIndex == 1)
					{
						if (item.trips <= maxValue | maxValue == -1)
						{
							chtResults.Series[0].Points.Add(new DataPoint(item.number, item.trips));
						}
					}
				}
			}
			else
			{
				chtResults.Series[0].Points.Clear();
			}
		}

		private void ddlPlotType_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateGraph();
		}

		private void tbxMaxValue_Leave(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tbxMaxValue.Text))
				tbxMaxValue.Text = "20000";
			updateGraph();
		}

		private void numericKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void startOrEnd_Leave(object sender, EventArgs e)
		{
			TextBox tbx = sender as TextBox;
			if (String.IsNullOrEmpty(tbx.Text))
				tbx.Text = "1";
		}
	}
}
