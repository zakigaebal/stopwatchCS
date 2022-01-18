namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lb_cho = new System.Windows.Forms.Label();
            this.Lb_Second = new System.Windows.Forms.Label();
            this.Dot = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.ListView();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lb_Minutes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(24, 46);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(91, 74);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "시작";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(239, 46);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(88, 74);
            this.Btn_Reset.TabIndex = 3;
            this.Btn_Reset.Text = "초기화";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // Lb_cho
            // 
            this.Lb_cho.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_cho.Location = new System.Drawing.Point(141, 20);
            this.Lb_cho.Name = "Lb_cho";
            this.Lb_cho.Size = new System.Drawing.Size(106, 80);
            this.Lb_cho.TabIndex = 4;
            this.Lb_cho.Text = "00";
            this.Lb_cho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Second
            // 
            this.Lb_Second.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_Second.Location = new System.Drawing.Point(253, 37);
            this.Lb_Second.Name = "Lb_Second";
            this.Lb_Second.Size = new System.Drawing.Size(66, 51);
            this.Lb_Second.TabIndex = 5;
            this.Lb_Second.Text = "00";
            this.Lb_Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dot.Location = new System.Drawing.Point(235, 44);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(22, 43);
            this.Dot.TabIndex = 7;
            this.Dot.Text = ".";
            this.Dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // record
            // 
            this.record.FullRowSelect = true;
            this.record.HideSelection = false;
            this.record.LabelWrap = false;
            this.record.Location = new System.Drawing.Point(23, 322);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(435, 215);
            this.record.TabIndex = 8;
            this.record.UseCompatibleStateImageBehavior = false;
            this.record.View = System.Windows.Forms.View.List;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(134, 46);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(88, 74);
            this.Btn_Save.TabIndex = 9;
            this.Btn_Save.Text = "저장";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Save_MouseDown);
            // 
            // Lb_Minutes
            // 
            this.Lb_Minutes.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_Minutes.Location = new System.Drawing.Point(30, 20);
            this.Lb_Minutes.Name = "Lb_Minutes";
            this.Lb_Minutes.Size = new System.Drawing.Size(105, 80);
            this.Lb_Minutes.TabIndex = 10;
            this.Lb_Minutes.Text = "00";
            this.Lb_Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(115, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 80);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dot);
            this.panel1.Controls.Add(this.Lb_cho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Lb_Minutes);
            this.panel1.Controls.Add(this.Lb_Second);
            this.panel1.Location = new System.Drawing.Point(64, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 125);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Reset);
            this.groupBox1.Location = new System.Drawing.Point(47, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "옵션";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.record);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lb_cho;
        private System.Windows.Forms.Label Lb_Second;
        private System.Windows.Forms.Label Dot;
        private System.Windows.Forms.ListView record;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lb_Minutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

