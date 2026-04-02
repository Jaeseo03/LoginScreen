namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_FontChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        string myID = "admin";
        string myPW = "superman";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                //MessageBox.Show("로그인 실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //e.SuppressKeyPress = true; // 기본 비프음 방지 (내 컴퓨터에서 오류 발생하여 주석처리)
                txtPW.Focus(); // 패스워드 입력창이 포커스를 갖게끔
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //e.SuppressKeyPress = true; // 기본 비프음 방지 (내 컴퓨터에서 오류 발생하여 주석처리)
                btnLogin.PerformClick(); // 버튼이 눌린 것처럼 만들기}
            }
        }

        // 아이디 텍스트 초기화 함수
        private void btnIDClear_Click(object sender, EventArgs e)
        {
            // 1. 텍스트 박스 초기화
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Silver;

            // 2. 에러 메시지 숨기기
            lblErrorMsg.Visible = false;

            // 3. 포커스를 다시 아이디 창으로
            txtID.Focus();
        }

        // 비밀번호 텍스트 초기화 함수
        private void btnPWClear_Click(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = false;
            txtPW.Text = "패스워드";
            txtPW.ForeColor = Color.Silver;

            // 2. 에러 메시지 숨기기
            lblErrorMsg.Visible = false;

            // 3. 포커스를 다시 아이디 창으로
            txtPW.Focus();
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder 상태("패스워드"라는 글자가 떠 있는 상태)가 아닐 때만 작동하게 하면 더 정교합니다.
            if (txtPW.Text != "패스워드")
            {
                // 체크박스가 체크되면 비밀번호를 보여주고, 해제되면 다시 가림
                txtPW.UseSystemPasswordChar = !chkShowPW.Checked;
            }
        }
    }
}