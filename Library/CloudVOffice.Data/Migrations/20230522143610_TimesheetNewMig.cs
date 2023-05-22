using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class TimesheetNewMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpportunityId",
                table: "Timesheets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivityCategory",
                table: "ProjectActivityTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateId", "CreatedBy", "CreatedDate", "DefaultSendingAccount", "Deleted", "EmailTemplateDescription", "EmailTemplateName", "Subject", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1L, new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(471), null, false, "<div class=\"\"> <div class=\"aHl\"><br></div> <div id=\":1pw\" tabindex=\"-1\"><br></div> <div id=\":1q7\" class=\"ii gt\" > <div id=\":1q8\" class=\"a3s aiL msg-3184750674626119538\"> <u>​</u> <div style=\"color:#1f272e;line-height:1.5\"> <table class=\"m_-3184750674626119538body-table m_-3184750674626119538with-container e-rte-table\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse:collapse;border-spacing:0;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;font-size:14px;font-weight:400;line-height:1.4;margin:0 auto;table-layout:fixed;background-color:#f4f5f6;color:#1f272e;height:100%!important;width:100%!important\" bgcolor=\"#f4f5f6\" height=\"100% !important\" width=\"100% !important\"> <tbody> <tr> <td class=\"m_-3184750674626119538body-content\" align=\"center\" valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;padding:60px 40px\"> <table class=\"m_-3184750674626119538email-container e-rte-table\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\" 600 \" style=\"margin:30px;background-color:#fff;border-radius:8px;border-spacing:0;max-width:600px;overflow:hidden;padding:30px\" bgcolor=\"#ffffff\"> <tbody> <tr> <td width=\"40\" align=\"left\" valign=\"middle\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> {%emailogo%} </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr> <td style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> <h1 style=\"font-size:20px;font-weight:600;margin-top:20px!important\"> <span>​</span> <span><span class=\"il\"> {%welcometitle%} </span></span> </h1> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"color:#1f272e;font-size:14px;border-radius:0 0 4px 4px;border-top:none;min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr style=\"border-bottom:none;border-collapse:collapse\"> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <p style=\"margin:5px 0!important\"><br></p> <p style=\"margin:5px 0!important\"> {%helloname%} </p> <p style=\"margin:5px 0!important\"> {%accountcreatetionmessage%} </p> <p style=\"margin:5px 0!important\"> {%loginidmessage%} </p> <p style=\"margin:5px 0!important\"> {%aditionalmessage%} </p> <p style=\"margin:15px 0\"> {%setpasswordlink%} </p> <br> <p style=\"margin:5px 0!important;margin-top:15px\"> {%emailsignature%} </p> <br> <p style=\"margin:5px 0!important\"> {%copylinkfrommessage%} </p> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100% !important\" style=\"font-size:12px;line-height:20px;border-top:none;min-width:100%!important;width:100%!important\" class=\"e-rte-table\"> <tbody> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\" class=\"\"> <div style=\"margin-top:40px;color:#687178!important\"> <div> <div style=\"white-space:normal\"> <p style=\"margin:0!important\"><br></p> </div> </div> <div> <div>------------------------------<wbr>------------------------------<wbr>------</div> <div></div> <div>This is a system generated mail. Please do not reply to this email.</div> <div></div> <div>© Copyright {%companyname%}, {%address%}</div> <div></div> <div> {%footerletterhera%} </div> <div></div> <div>The information contained in this e-mail message and/or attachments to it may contain confidential <br>or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,<br> printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited. <br>If you have received this communication in error, please notify us by reply e-mail or telephone and immediately <br>and permanently delete the message and any attachments. Thank you.</div> </div> <div> </div> </div> </td> </tr> <tr> <td valign=\"top\" style=\"font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif\"> <div><br></div> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> <div class=\"yj6qo\"><br></div> <div class=\"adL\"></div> </div> <div class=\"adL\"> </div> </div> </div> <div id=\":1ps\" class=\"ii gt\" style=\"display:none\"> <div id=\":1pr\" class=\"a3s aiL \"><br></div> </div> <div class=\"hi\"><br></div> </div>", "WelcomeEmail", "", null, null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9451));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "Timesheets");

            migrationBuilder.DropColumn(
                name: "ActivityCategory",
                table: "ProjectActivityTypes");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 447, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(7950));
        }
    }
}
