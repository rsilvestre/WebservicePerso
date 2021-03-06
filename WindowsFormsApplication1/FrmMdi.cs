﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
	public partial class FrmMdi : Form {
		private int childFormNumber = 0;
		private FrmSplashScreen _splashScreen;
		private AutoResetEvent AutoEvent = new AutoResetEvent(false);

		private Int32 _iLockMDI;

		public Int32 ILockMDI {
			get { return _iLockMDI; }
			set { _iLockMDI = value; }
		}

		public FrmMdi() {
			InitializeComponent();
		}

		public void DecrementILockMDI() {

			Interlocked.Decrement(ref _iLockMDI);
			if (_iLockMDI == 0) {
				AutoEvent.Set();
			}
		}

		public void SetLoadingText(String text) {
			try {
				_splashScreen.LoadginText = text;
				_splashScreen.Dostep(1);
			} catch (Exception Ex) {
				throw;
			}
		}

		private void FrmMdi_Load(object sender, EventArgs e) {
			ILockMDI = 2;
			try {
				_splashScreen = new FrmSplashScreen(this);
				_splashScreen.Show();
				_splashScreen.EnableConnect(CGlobalCache.LoadCache(this));

				while (!AutoEvent.WaitOne(50, true)) {
					Application.DoEvents();
				}

				if (_splashScreen.Connect) {
					_splashScreen.Close();
					WindowState = FormWindowState.Maximized;
				} else {
					_splashScreen.Close();
				}

			} catch (Exception Ex) {
				_splashScreen.Close();
				Close();
			}
		}





		private void ShowNewForm(object sender, EventArgs e) {
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Window " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
		}


		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
			foreach (Form childForm in MdiChildren) {
				childForm.Close();
			}
		}
	}
}
