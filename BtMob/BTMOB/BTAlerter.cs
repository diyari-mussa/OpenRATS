using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class BTAlerter
{
	public static void custom(string msg, Bitmap img, Color rondcolor)
	{
		Alert.ShowCustom(TranslateMessage(msg), img, rondcolor);
	}

	public static void Success(string msg)
	{
		Alert.ShowSucess(TranslateMessage(msg));
	}

	public static void Warnings(string msg)
	{
		Alert.ShowWarning(TranslateMessage(msg));
	}

	public static void infos(string msg)
	{
		Alert.ShowInformation(TranslateMessage(msg));
	}

	public static void erroes(string msg)
	{
		Alert.ShowError(TranslateMessage(msg));
	}

	private static string TranslateMessage(string P_0)
	{
		return P_0 switch
		{
			"invalid Email or Password." => "邮箱或密码无效。", 
			"Your subscription has expired." => "订阅已过期。", 
			"your account is not activated." => "账户未激活。", 
			"Your account is not active 1952" => "账户未激活。", 
			"Your account is not activiated." => "账户未激活。", 
			"account is not activated 9." => "账户未激活。", 
			"This device is not activated." => "此设备未激活。", 
			"check your 2FA code" => "请检查两步验证码。", 
			"Please check your 2FA Code." => "请检查两步验证码。", 
			"Please check your 2FA Code" => "请检查两步验证码。", 
			"2FA is not Enabled !!!" => "两步验证未启用！", 
			"Phone Not Found !" => "未找到设备！", 
			"Phone is not online" => "设备不在线。", 
			"Invalid or expired token." => "令牌无效或已过期。", 
			"Invalid login." => "登录无效。", 
			"Invalid login (1), try reload the page" => "登录无效，请刷新页面重试。", 
			"Invalid login (2), try reload the page" => "登录无效，请刷新页面重试。", 
			"Invalid login (3), try reload the page" => "登录无效，请刷新页面重试。", 
			"Authentication login failed" => "登录验证失败。", 
			"Error while logging in." => "登录时出错。", 
			"Exception login, please try again later." => "登录异常，请稍后再试。", 
			"(1) Please Check your password." => "请检查密码。", 
			"invalid Session, please check your secret key." => "会话无效，请检查密钥。", 
			"1 login invalid, please check your secret key" => "登录无效，请检查密钥。", 
			"2 login invalid, please check your secret key" => "登录无效，请检查密钥。", 
			"Complete your payment." => "请完成付款。", 
			"To Many Request \n Please Slow Down" => "请求过多，请放慢操作。", 
			"To Many Request..." => "请求过多。", 
			"invalid Request \n Reload your Page" => "无效请求，请刷新页面。", 
			"(0) invalid Request" => "无效请求。", 
			"Invalid request." => "无效请求。", 
			"Invalid request param." => "请求参数无效。", 
			"Invalid request command." => "请求命令无效。", 
			"Invalid user id." => "用户无效。", 
			"Invalid app id." => "应用无效。", 
			"Database error occurred." => "数据库错误。", 
			"Error occurred." => "发生错误。", 
			"Server not available right now." => "服务器当前不可用。", 
			"Server Rejected request." => "服务器拒绝请求。", 
			"File not found !!!" => "未找到文件！", 
			"Upload failed." => "上传失败。", 
			"Failed to copy APK." => "复制 APK 失败。", 
			"Failed to copy tools." => "复制工具失败。", 
			"APK analysis failed." => "APK 解析失败。", 
			"Invalid package name." => "包名无效。", 
			"App name must not exceed 23 characters" => "应用名称过长，最多23个字符。", 
			"App name too long." => "应用名称过长。", 
			"Client name must not exceed 16 characters" => "客户端名称过长，最多16个字符。", 
			"File size exceeds the maximum allowed size of 5 MB." => "文件大小超出限制（5MB）。", 
			"File size exceeds the maximum allowed size of 50 MB." => "文件大小超出限制（50MB）。", 
			"Please upload a valid .apk file." => "请上传有效的 APK 文件。", 
			"Please upload a valid APK file." => "请上传有效的 APK 文件。", 
			"Please upload a valid PNG image." => "请上传有效的 PNG 图片。", 
			"Invalid PNG file." => "PNG 文件无效。", 
			"Invalid image file." => "图片文件无效。", 
			"App deleted successfully" => "应用删除成功。", 
			"App could not be deleted" => "应用删除失败。", 
			"icon removed successfully" => "图标删除成功。", 
			"Image processing failed." => "图片处理失败。", 
			"No device selected." => "未选择设备。", 
			"UI view updated successfully." => "界面视图更新成功。", 
			"Error: Failed to retrieve UI dump." => "错误：获取界面转储失败。", 
			"Select clients first" => "请先选择客户端。", 
			"No Apps found , try create new" => "未找到应用，请新建。", 
			"Select app to download" => "请选择要下载的应用。", 
			"Select screen type." => "请选择屏幕类型。", 
			"Online status updated successfully" => "在线状态更新成功。", 
			"App set to Checking." => "应用已设为审核中。", 
			"App finalized." => "应用已完成。", 
			"App marked Rejected." => "应用已被拒绝。", 
			"251 Something went wrong please try again later." => "出错了，请稍后再试。", 
			"518 Something went wrong please try again later." => "出错了，请稍后再试。", 
			"493 Something went wrong please try again later." => "出错了，请稍后再试。", 
			"964 Something went wrong please try again later." => "出错了，请稍后再试。", 
			"031 Something went wrong please try again later." => "出错了，请稍后再试。", 
			"051 Something went wrong please try again later." => "出错了，请稍后再试。", 
			"Something went wrong please try again later." => "出错了，请稍后再试。", 
			"Something went wrong , please try again later." => "出错了，请稍后再试。", 
			"(321) something went wrong , please try again later." => "出错了，请稍后再试。", 
			"something went wrong 444." => "出错了，请稍后再试。", 
			"oops something went wrong , Please try again later" => "出错了，请稍后再试。", 
			"ops , something wrong , try again later (21)" => "出错了，请稍后再试。", 
			"Blocked" => "已阻止。", 
			"expired" => "已过期。", 
			"Done" => "完成。", 
			"ok" => "成功。", 
			"wait" => "请稍候。", 
			_ => P_0, 
		};
	}
}
