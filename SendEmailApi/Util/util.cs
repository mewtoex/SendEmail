using System.Net.Mail;
using System.Net.Mime;

namespace SendEmailApi.Util
{
    public class util
    {

        //public static bool sendEmailForApi(String aSendToEmail, String aCode)
        //public bool sendEmailForApi(person value, String aCode)
        public bool sendEmailForApi(string value)
        {
            try
            {
                System.Net.Mail.MailMessage lMailMsg = new System.Net.Mail.MailMessage();
                lMailMsg.Priority = System.Net.Mail.MailPriority.Normal;
                lMailMsg.IsBodyHtml = true;
                lMailMsg.Body = buidHTMLcodeValidationEmail();
                lMailMsg.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
                lMailMsg.Subject = "Title";
                lMailMsg.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
                string[] lEmailDest = new string[1];
                lEmailDest[0] = value;

                //return sendEMailTemplate(emailDestiny, useSSL, rextEmail, provider, youMailSend, youPassword, port, youMailSend");

                return sendEMailTemplate(lEmailDest, true, lMailMsg, "smtp.mail.yahoo.com",  "w@yahoo.com.br", "c", 587, "w@yahoo.com.br");


            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool sendEMailTemplate(string[] emailDestiny, bool lSSl, System.Net.Mail.MailMessage lMessageMail, string lSmtpServer,  string login, string password, int port, string emailSender)
        {
            try
            {
                System.Net.Mail.SmtpClient lSmtpClient = new System.Net.Mail.SmtpClient(lSmtpServer);
                System.Net.Mail.MailMessage lMsgMail = new System.Net.Mail.MailMessage();


                lMsgMail = lMessageMail;

                for (int i = 0; i < emailDestiny.Length; i++)
                {
                    lMsgMail.To.Add(new System.Net.Mail.MailAddress(emailDestiny[i]));
                }

                lMsgMail.From = new System.Net.Mail.MailAddress(emailSender);

                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(login, password);

                lSmtpClient.UseDefaultCredentials = false;
                lSmtpClient.Credentials = cred;
                lSmtpClient.Port = port;
                lSmtpClient.EnableSsl = lSSl;
                lSmtpClient.Send(lMsgMail);


                return true;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message + " " + ex.Message);

            }
            return false;
        }

        static public string buidHTMLcodeValidationEmail(string aLanguage = "pt-br")
        {
            try
            {
             

                StringWriter lSw = new StringWriter();
               

                String lStr = "";
                lStr += "<HTML style=\"background-color:white\"> ";
                lStr += "<HEADER  class=\"auto-style1\" style=\" font-weight: bold;font-size: 20px; \" >  </HEADER> ";
                lStr += "	 	    <br><br><br><br>  ";
                lStr += "	 		<div align='center' style=\"width: 100%\">  ";
                lStr += "	 		     <p align='center' class=\"auto-style1\" style=\"  \">    ";
                lStr += "	 		    </p>  ";
                lStr += "	 		    <p align='center' class=\"auto-style1\" style=\" font-size: 20px; \">  ";
                lStr += "	 		    	<strong class=\"auto-style2\"> Texto aqui  </ strong > ";
                lStr += "	 		    </p>   ";
                lStr += "	 		    <div align='center' style=\"width: 400px;\">  ";
                lStr += "	 		    	<p align='justify' style=\"color: darkGrey\"  class=\"auto-style\"  >  ";
                lStr += "	 		    		<strong class=\"auto-style\" style=\" font-size: 12px; \">  Texto aqui </strong> ";
                lStr += "	 		    	</p>  ";
                lStr += "	 		    </div>   ";
                lStr += "	 	    </div>  ";
                lStr += "	 		<p class=\"auto-style1\">   ";
                lStr += "	 	    <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>  ";
                lStr += "	 	    <hr>  ";
                lStr += "	 	    <br>  ";
                lStr += " </HTML> ";
                return lStr;

            }
            catch (Exception)
            {
                return "Erro de envio!";
            }

        }

    }
}
