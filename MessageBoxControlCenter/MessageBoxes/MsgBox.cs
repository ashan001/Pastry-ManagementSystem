using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxControlCenter.MessageBoxes
{
    public class MsgBox
    {
        public static DialogResult Question(string msg)
        {
            return MessageBox.Show(msg,"Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public static DialogResult InvalidUser(string msg)
        {
            return MessageBox.Show(msg,"Invalid",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public static DialogResult Exception(Exception ex)
        {
            return MessageBox.Show(ex.Message,"Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static DialogResult Information(string msg)
        {
            return MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static DialogResult Warning(string msg)
        {
            return MessageBox.Show(msg,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public static DialogResult Error(string msg)
        {
            return MessageBox.Show(msg,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static DialogResult Show(bool result)
        {
            if (result)
                return MessageBox.Show("Successfully saved","Informatin",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                return MessageBox.Show("Record saving failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static DialogResult Show(int result)
        {
            switch (result)
            {
                case 0:
                    return MessageBox.Show("Not allowed to change the specified key","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                case 1:
                    return MessageBox.Show("Successfully saved","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                case 2:
                    return MessageBox.Show("Record already exist, Do you want to update?","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                case 3:
                    return MessageBox.Show("Record saving failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                case 4:
                    return MessageBox.Show("Invalid user name / Password combination","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                case 5:
                    return MessageBox.Show("Please check the connection and try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                case 6:
                    return MessageBox.Show("Data updated successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                case 7:
                    return MessageBox.Show("Please Select From date and To Date To Filter Data ");
                case 8:
                    return MessageBox.Show("Invalid User Access","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                case 9:
                    return MessageBox.Show("Data updation is failed","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                default:
                    throw new Exception("Message not defined for " + result);
            }
        }
        public static DialogResult ShowDeleteStatus(int result)
        {
            switch (result)
            {
                case 1:
                    return MessageBox.Show("Successfully deleted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                case 2:
                    return MessageBox.Show("Record deleting failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                default:
                    throw new Exception("Message not defined for " + result);
            }
        }
    }
}
