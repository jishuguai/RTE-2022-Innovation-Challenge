﻿
namespace RTRemoteHelper
{
    partial class ChannelMediaRelayView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.localVideoView = new System.Windows.Forms.PictureBox();
            this.remoteVideoView = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMediaRelay = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.localVideoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteVideoView)).BeginInit();
            this.SuspendLayout();
            // 
            // localVideoView
            // 
            this.localVideoView.Location = new System.Drawing.Point(3, 4);
            this.localVideoView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.localVideoView.Name = "localVideoView";
            this.localVideoView.Size = new System.Drawing.Size(122, 112);
            this.localVideoView.TabIndex = 2;
            this.localVideoView.TabStop = false;
            // 
            // remoteVideoView
            // 
            this.remoteVideoView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remoteVideoView.Cursor = System.Windows.Forms.Cursors.Default;
            this.remoteVideoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteVideoView.Location = new System.Drawing.Point(0, 0);
            this.remoteVideoView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remoteVideoView.Name = "remoteVideoView";
            this.remoteVideoView.Size = new System.Drawing.Size(760, 600);
            this.remoteVideoView.TabIndex = 4;
            this.remoteVideoView.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "跨频道";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "MediaRelay 频道号";
            // 
            // textBoxMediaRelay
            // 
            this.textBoxMediaRelay.Location = new System.Drawing.Point(152, 554);
            this.textBoxMediaRelay.Name = "textBoxMediaRelay";
            this.textBoxMediaRelay.Size = new System.Drawing.Size(303, 27);
            this.textBoxMediaRelay.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(474, 546);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 42);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = " StartMediaRelay";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ChannelMediaRelayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBoxMediaRelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localVideoView);
            this.Controls.Add(this.remoteVideoView);
            this.Name = "ChannelMediaRelayView";
            this.Size = new System.Drawing.Size(760, 600);
            ((System.ComponentModel.ISupportInitialize)(this.localVideoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteVideoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox localVideoView;
        public System.Windows.Forms.PictureBox remoteVideoView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMediaRelay;
        private System.Windows.Forms.Button btnStart;
    }
}
