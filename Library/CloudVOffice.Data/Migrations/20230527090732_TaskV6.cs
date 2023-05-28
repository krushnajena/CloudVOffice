using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsDelayApproved",
                table: "ProjectTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailTemplateDescription" },
                values: new object[] { new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9857), "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\">\r\n                                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">{%welcometitle%} </h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\">\r\n                                                            <table border=\"0\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <h5 style=\"font-weight:400; margin-bottom:0; font-size:16px; color:#676767\"><span style=\"color:rgb(22,123,158); font-size:16px; margin-right:2px; font-weight:600\"></span>{%helloname%}</h5>\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">{%accountcreatetionmessage%}</p>\r\n\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">{%loginidmessage%}</p>\r\n\r\n\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">{%aditionalmessage%}</p>\r\n                                                                                <div style=\"margin:20px 0 0 0; text-align:center\">{%setpasswordlink%}</div>\r\n                                                                                <br />\r\n                                                                                {%copylinkfrommessage%}\r\n                                                                            </div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table border=\"0\" style=\"width:100%\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table border=\"0\" style=\"width:100%\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"></div> </div></span>\r\n</div>" });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 27, 14, 37, 32, 15, DateTimeKind.Local).AddTicks(9009));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDelayApproved",
                table: "ProjectTasks",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4277));

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
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4614));

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
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 22, 31, 7, 263, DateTimeKind.Local).AddTicks(2411));
        }
    }
}
