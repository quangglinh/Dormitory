using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormitoryManager.AppCode {
    class UIUtil {
        public static bool FillRoom(Control txtRoom, Control txtSlot, Control txtDom, Control txtFee, Control txtMaxSlot, Room room, int slot) {
            if (room == null) {
                txtSlot.Text = txtRoom.Text = txtDom.Text = txtFee.Text = txtMaxSlot.Text = "Not Found";
                return false;
            }
            txtSlot.Text = slot.ToString();
            txtRoom.Text = room.ID;
            txtDom.Text = room.Dom;
            txtFee.Text = room.Fee.ToString();
            txtMaxSlot.Text = room.NoSlot.ToString();
            return true;
        }

        public static bool FillStatus(Control electric, Control water, Control extra, Control extrainfo, Control info, CheckBox complete,  StudentStatus status) {
            if (status == null) {
                electric.Text = water.Text = extra.Text = extrainfo.Text = info.Text= "Not Found";
                complete.Checked = false;
                return false;
            }
            
            electric.Text = status.ElectricCost.ToString();
            water.Text = status.WaterCost.ToString();
            extra.Text = status.ExtraFee.ToString();
            extrainfo.Text = status.ExtraNote;
            info.Text = status.Note;
            complete.Checked = status.Complete;
            return true;
        }

        public static bool FillStudent(Control name, Control mail, Control phone, Label ok, Student student) {
            if (student == null) {
                name.Text = mail.Text = phone.Text = "Not Found";
                ok.Text = "Not Found";
                ok.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            name.Text = student.Name;
            mail.Text = student.Email;
            phone.Text = student.Phone;
            ok.Text = "Found";
            ok.ForeColor = System.Drawing.Color.Green;
            return true;
        }

    }
}
