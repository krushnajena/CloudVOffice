using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class DBV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                columns: new[] { "ApplicationName", "CreatedDate", "IsGroup", "Url" },
                values: new object[] { "Company Settings", new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4263), true, "" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                columns: new[] { "ApplicationName", "CreatedDate", "IsGroup", "Parent", "Url" },
                values: new object[] { "Company", new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4265), false, 3, "/Setup/CompanyDetails/CompanyDetailsView" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                columns: new[] { "ApplicationName", "CreatedDate", "Parent", "Url" },
                values: new object[] { "Letter Head", new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4266), 3, "/Setup/LetterHead/LetterHeadView" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "ApplicationName", "CreatedDate", "IsGroup", "Url" },
                values: new object[] { "User", new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4268), true, "" });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "ApplicationId1", "ApplicationName", "AreaName", "CreatedBy", "CreatedDate", "Deleted", "IconClass", "IconImageUrl", "IsGroup", "Parent", "UpdatedBy", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 7, null, "User List", "Setup", 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4270), false, null, null, false, 6, null, null, "/Setup/User/UserList" },
                    { 8, null, "Email Setup", "Setup", 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4271), false, null, null, true, 2, null, null, "" },
                    { 9, null, "Domain", "Setup", 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4275), false, null, null, true, 8, null, null, "/Setup/EmailDomain/EmailDomainView" },
                    { 10, null, "Email Account", "Setup", 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4277), false, null, null, true, 8, null, null, "/Setup/EmailAccount/EmailAccountView" }
                });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailTemplateDescription" },
                values: new object[] { new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(5156), "<div class=\"\"> <div class=\"aHl\"><br></div> <div id=\":1pw\" tabindex=\"-1\"><br></div> <div id=\":1q7\" class=\"ii gt\" > <div id=\":1q8\" class=\"a3s aiL msg-3184750674626119538\"> <u>​</u> <div style=\"color:#1f272e;line-height:1.5\"> <table class=\"m_-3184750674626119538body-table m_-3184750674626119538with-container e-rte-table\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse:collapse;border-spacing:0;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;font-size:14px;font-weight:400;line-height:1.4;margin:0 auto;table-layout:fixed;background-color:#f4f5f6;color:#1f272e;height:100%!important;width:100%!important\" bgcolor=\"#f4f5f6\" height=\"100% !important\" width=\"100% !important\"> <tbody> <tr> <td class=\"m_-3184750674626119538body-content\" align=\"center\" valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;padding:60px 40px\"> <table class=\"m_-3184750674626119538email-container e-rte-table\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\" 600 \" style=\"background-color:#fff;border-radius:8px;border-spacing:0;max-width:600px;overflow:hidden;padding:30px\" bgcolor=\"#ffffff\"> <tbody> <tr> <td width=\"40\" align=\"left\" valign=\"middle\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> {%emailogo%} </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr> <td style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> <h1 style=\"font-size:20px;font-weight:600;margin-top:20px!important\"> <span>​</span> <span><span class=\"il\"> {%welcometitle%} </span></span> </h1> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"color:#1f272e;font-size:14px;border-radius:0 0 4px 4px;border-top:none;min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr style=\"border-bottom:none;border-collapse:collapse\"> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <p style=\"margin:5px 0!important\"><br></p> <p style=\"margin:5px 0!important\"> {%helloname%} </p> <p style=\"margin:5px 0!important\"> {%accountcreatetionmessage%} </p> <p style=\"margin:5px 0!important\"> {%loginidmessage%} </p> <p style=\"margin:5px 0!important\"> {%aditionalmessage%} </p> <p style=\"margin:15px 0\"> {%setpasswordlink%} </p> <br> <p style=\"margin:5px 0!important;margin-top:15px\"> {%emailsignature%} </p> <br> <p style=\"margin:5px 0!important\"> {%copylinkfrommessage%} </p> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"font-size:12px;line-height:20px;border-top:none;min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> <div style=\"margin-top:40px;color:#687178!important\"> <div> <div style=\"white-space:normal\"> <p style=\"margin:0!important\"><br></p> </div> </div> <div> <div>------------------------------<wbr>------------------------------<wbr>------</div> <div></div> <div>This is a system generated mail. Please do not reply to this email.</div> <div></div> <div>© Copyright {%companyname%}, {%address%}</div> <div></div> <div> {%footerletterhera%} </div> <div></div> <div>The information contained in this e-mail message and/or attachments to it may contain confidential <br>or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,<br> printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited. <br>If you have received this communication in error, please notify us by reply e-mail or telephone and immediately <br>and permanently delete the message and any attachments. Thank you.</div> </div> <div> </div> </div> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <div><br></div> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> <div class=\"yj6qo\"><br></div> <div class=\"adL\"></div> </div> <div class=\"adL\"> </div> </div> </div> <div id=\":1ps\" class=\"ii gt\" style=\"display:none\"> <div id=\":1pr\" class=\"a3s aiL \"><br></div> </div> <div class=\"hi\"><br></div> </div>" });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 254, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.InsertData(
                table: "RoleAndApplicationWisePermissions",
                columns: new[] { "RoleAndApplicationWisePermissionId", "ApplicationId", "CreatedBy", "CreatedDate", "Deleted", "RoleId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7L, 7, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4611), false, 1, null, null },
                    { 8L, 8, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4612), false, 1, null, null },
                    { 9L, 9, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4613), false, 1, null, null },
                    { 10L, 10, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4614), false, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserWiseViewMappers",
                columns: new[] { "UserWiseViewMapperId", "ApplicationId", "CreatedBy", "CreatedDate", "Deleted", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 7L, 7, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4861), false, null, null, 1L },
                    { 8L, 8, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4862), false, null, null, 1L },
                    { 9L, 9, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4869), false, null, null, 1L },
                    { 10L, 10, 1L, new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4883), false, null, null, 1L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                columns: new[] { "ApplicationName", "CreatedDate", "IsGroup", "Url" },
                values: new object[] { "Company", new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(618), false, "/Setup/Company/Company" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                columns: new[] { "ApplicationName", "CreatedDate", "IsGroup", "Parent", "Url" },
                values: new object[] { "User", new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(619), true, 2, "" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                columns: new[] { "ApplicationName", "CreatedDate", "Parent", "Url" },
                values: new object[] { "User List", new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(621), 4, "/Setup/User/UserList" });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "ApplicationName", "CreatedDate", "IsGroup", "Url" },
                values: new object[] { "Users Activity Log", new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(623), false, "/Setup/User/ActivityLog" });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailTemplateDescription" },
                values: new object[] { new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(1080), "<div class=\"\"> <div class=\"aHl\"><br></div> <div id=\":1pw\" tabindex=\"-1\"><br></div> <div id=\":1q7\" class=\"ii gt\" > <div id=\":1q8\" class=\"a3s aiL msg-3184750674626119538\"> <u>​</u> <div style=\"color:#1f272e;line-height:1.5\"> <table class=\"m_-3184750674626119538body-table m_-3184750674626119538with-container e-rte-table\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse:collapse;border-spacing:0;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;font-size:14px;font-weight:400;line-height:1.4;margin:0 auto;table-layout:fixed;background-color:#f4f5f6;color:#1f272e;height:100%!important;width:100%!important\" bgcolor=\"#f4f5f6\" height=\"100% !important\" width=\"100% !important\"> <tbody> <tr> <td class=\"m_-3184750674626119538body-content\" align=\"center\" valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;padding:60px 40px\"> <table class=\"m_-3184750674626119538email-container e-rte-table\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\" 600 \" style=\"margin:30px;background-color:#fff;border-radius:8px;border-spacing:0;max-width:600px;overflow:hidden;padding:30px\" bgcolor=\"#ffffff\"> <tbody> <tr> <td width=\"40\" align=\"left\" valign=\"middle\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> {%emailogo%} </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr> <td style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> <h1 style=\"font-size:20px;font-weight:600;margin-top:20px!important\"> <span>​</span> <span><span class=\"il\"> {%welcometitle%} </span></span> </h1> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"color:#1f272e;font-size:14px;border-radius:0 0 4px 4px;border-top:none;min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr style=\"border-bottom:none;border-collapse:collapse\"> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <p style=\"margin:5px 0!important\"><br></p> <p style=\"margin:5px 0!important\"> {%helloname%} </p> <p style=\"margin:5px 0!important\"> {%accountcreatetionmessage%} </p> <p style=\"margin:5px 0!important\"> {%loginidmessage%} </p> <p style=\"margin:5px 0!important\"> {%aditionalmessage%} </p> <p style=\"margin:15px 0\"> {%setpasswordlink%} </p> <br> <p style=\"margin:5px 0!important;margin-top:15px\"> {%emailsignature%} </p> <br> <p style=\"margin:5px 0!important\"> {%copylinkfrommessage%} </p> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"font-size:12px;line-height:20px;border-top:none;min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> <div style=\"margin-top:40px;color:#687178!important\"> <div> <div style=\"white-space:normal\"> <p style=\"margin:0!important\"><br></p> </div> </div> <div> <div>------------------------------<wbr>------------------------------<wbr>------</div> <div></div> <div>This is a system generated mail. Please do not reply to this email.</div> <div></div> <div>© Copyright {%companyname%}, {%address%}</div> <div></div> <div> {%footerletterhera%} </div> <div></div> <div>The information contained in this e-mail message and/or attachments to it may contain confidential <br>or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,<br> printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited. <br>If you have received this communication in error, please notify us by reply e-mail or telephone and immediately <br>and permanently delete the message and any attachments. Thank you.</div> </div> <div> </div> </div> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <div><br></div> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> <div class=\"yj6qo\"><br></div> <div class=\"adL\"></div> </div> <div class=\"adL\"> </div> </div> </div> <div id=\":1ps\" class=\"ii gt\" style=\"display:none\"> <div id=\":1pr\" class=\"a3s aiL \"><br></div> </div> <div class=\"hi\"><br></div> </div>" });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 985, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 22, 29, 30, 986, DateTimeKind.Local).AddTicks(139));
        }
    }
}
