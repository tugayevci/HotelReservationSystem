using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mail
    {
        public bool SendReservationInfoMail(Reservation reservation)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("hotelgitinfomail@gmail.com");
            //
            ePosta.To.Add(HelperStaticClass.appUserStatic.UserEmail);
            //
            //
            ePosta.Subject = "Reservation Info - Do Not Reply";

            string info = $"Reservation No: {reservation.ID} \nUser: {HelperStaticClass.appUserStatic.UserName} \nCheck In: {reservation.CheckInDate} \nCheck Out:{reservation.CheckOutDate} \nThank you for choosing us! \nHotel G.I.T";

            ePosta.Body = info;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("hotelgitinfomail@gmail.com", "193746825");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
            }
            return kontrol;
        }
    }
}
