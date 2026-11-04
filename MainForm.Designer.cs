namespace ShapeApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            shapeMenu = new System.Windows.Forms.ToolStripMenuItem();
            lineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            curveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            canvasHost = new System.Windows.Forms.Panel();
            canvas = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            canvasHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { shapeMenu });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(709, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // shapeMenu
            // 
            shapeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { lineMenuItem, toolStripSeparator1, rectangleToolStripMenuItem, circleToolStripMenuItem, pieToolStripMenuItem, polygonToolStripMenuItem, curveToolStripMenuItem, clearMenuItem });
            shapeMenu.Name = "shapeMenu";
            shapeMenu.Size = new System.Drawing.Size(56, 24);
            shapeMenu.Text = "Дүрс";
            // 
            // lineMenuItem
            // 
            lineMenuItem.Name = "lineMenuItem";
            lineMenuItem.Size = new System.Drawing.Size(224, 26);
            lineMenuItem.Text = "Шулуун";
            lineMenuItem.Click += lineMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            rectangleToolStripMenuItem.Text = "Тэгш өнцөгт";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            circleToolStripMenuItem.Text = "Дугуй";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // pieToolStripMenuItem
            // 
            pieToolStripMenuItem.Name = "pieToolStripMenuItem";
            pieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            pieToolStripMenuItem.Text = "Pie";
            pieToolStripMenuItem.Click += pieToolStripMenuItem_Click;
            // 
            // polygonToolStripMenuItem
            // 
            polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            polygonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            polygonToolStripMenuItem.Text = "Polygon";
            polygonToolStripMenuItem.Click += polygonToolStripMenuItem_Click;
            // 
            // curveToolStripMenuItem
            // 
            curveToolStripMenuItem.Name = "curveToolStripMenuItem";
            curveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            curveToolStripMenuItem.Text = "Curve";
            curveToolStripMenuItem.Click += curveToolStripMenuItem_Click;
            // 
            // clearMenuItem
            // 
            clearMenuItem.Name = "clearMenuItem";
            clearMenuItem.Size = new System.Drawing.Size(224, 26);
            clearMenuItem.Text = "Цэвэрлэх";
            clearMenuItem.Click += clearMenuItem_Click_1;
            // 
            // canvasHost
            // 
            canvasHost.Controls.Add(canvas);
            canvasHost.Dock = System.Windows.Forms.DockStyle.Fill;
            canvasHost.Location = new System.Drawing.Point(0, 30);
            canvasHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            canvasHost.Name = "canvasHost";
            canvasHost.Padding = new System.Windows.Forms.Padding(14, 16, 14, 16);
            canvasHost.Size = new System.Drawing.Size(709, 557);
            canvasHost.TabIndex = 1;
            // 
            // canvas
            // 
            canvas.BackColor = System.Drawing.Color.White;
            canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            canvas.Location = new System.Drawing.Point(14, 16);
            canvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            canvas.Name = "canvas";
            canvas.Size = new System.Drawing.Size(681, 525);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.Resize += canvas_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(709, 587);
            Controls.Add(canvasHost);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(455, 411);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Дасгал№2. Энгийн дүрсүүд зурах";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            canvasHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeMenu;
        private System.Windows.Forms.ToolStripMenuItem lineMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel canvasHost;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
    }
}
