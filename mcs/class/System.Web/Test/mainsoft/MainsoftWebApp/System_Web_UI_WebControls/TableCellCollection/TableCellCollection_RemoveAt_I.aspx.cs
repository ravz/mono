//
// Authors:
//   Rafael Mizrahi   <rafim@mainsoft.com>
//   Erez Lotan       <erezl@mainsoft.com>
//   Vladimir Krasnov <vladimirk@mainsoft.com>
//
//
// Copyright (c) 2002-2005 Mainsoft Corporation.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GHTTests.System_Web_dll.System_Web_UI_WebControls
{
	public class TableCellCollection_RemoveAt_I
		: GHTBaseWeb 
	{
		protected GHTWebControls.GHTSubTest GHTSubTest1;
		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) 
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() 
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Page_Load(object sender, System.EventArgs e) 
		{
			//Put user code to initialize the page here
			base.GHTTestBegin((HtmlForm)this.FindControl("Form1"));

			System.Web.UI.WebControls.Table tbl = new System.Web.UI.WebControls.Table();
			tbl.Rows.Add(new System.Web.UI.WebControls.TableRow());
			tbl.Rows.Add(new System.Web.UI.WebControls.TableRow());

			//add new cell
			tbl.Rows[0].Cells.Add(new System.Web.UI.WebControls.TableCell());
			tbl.Rows[0].Cells.Add(new System.Web.UI.WebControls.TableCell());
			tbl.Rows[0].Cells.Add(new System.Web.UI.WebControls.TableCell());
			tbl.Rows[0].Cells.Add(new System.Web.UI.WebControls.TableCell());

			tbl.Rows[0].Cells[0].Text = "111";
			tbl.Rows[0].Cells[1].Text = "222";
			tbl.Rows[0].Cells[2].Text = "333";
			tbl.Rows[0].Cells[3].Text = "444";


			try 
			{
				base.GHTSubTestBegin("RemoveAt");
				base.GHTActiveSubTest.Controls.Add(tbl);
				tbl.Rows[0].Cells.RemoveAt(1);
			}
			catch (Exception ex) 
			{
				base.GHTSubTestUnexpectedExceptionCaught(ex);
			}
			base.GHTSubTestEnd();

			base.GHTTestEnd();
		}
	}
}
