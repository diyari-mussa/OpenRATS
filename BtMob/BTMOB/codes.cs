#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using BTMOB.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WMPLib;

namespace BTMOB;

[StandardModule]
internal sealed class codes
{
	private static string lasthwid = null;

	private static Random r = null;

	private static string[] randmid2 = new string[290]
	{
		EXGuarder._2A371659,
		EXGuarder._61004C69,
		EXGuarder._4E1B5D52,
		EXGuarder._4C262903,
		EXGuarder._49703D39,
		EXGuarder._765F6E3E,
		EXGuarder._62620234,
		EXGuarder._0E6F0637,
		EXGuarder._0A4A1D4F,
		EXGuarder._0642024A,
		EXGuarder._64406F5D,
		EXGuarder._4C4B5F24,
		EXGuarder._4E265A1E,
		EXGuarder._27460676,
		EXGuarder._2B361B33,
		EXGuarder._0F03471B,
		EXGuarder._514A7423,
		EXGuarder._3C0C1E4E,
		EXGuarder._0D353268,
		EXGuarder._1421614C,
		EXGuarder._64795266,
		EXGuarder._321F3026,
		EXGuarder._1857776F,
		EXGuarder._26581D17,
		EXGuarder._12053E5C,
		EXGuarder._0413476E,
		EXGuarder._086A062C,
		EXGuarder._640D1E4A,
		EXGuarder._3D176E4E,
		EXGuarder._42355B55,
		EXGuarder._7149490A,
		EXGuarder._604D4F5D,
		EXGuarder._5B25002B,
		EXGuarder._17085465,
		EXGuarder._096F2E6F,
		EXGuarder._4E53422E,
		EXGuarder._3E4C3C12,
		EXGuarder._59706D39,
		EXGuarder._39487745,
		EXGuarder._122A6971,
		EXGuarder._6E3D3612,
		EXGuarder._1E162408,
		EXGuarder._0E6B0F31,
		EXGuarder._3F2B4C21,
		EXGuarder._1A152C6C,
		EXGuarder._2E1C6E37,
		EXGuarder._516A6547,
		EXGuarder._0A545A36,
		EXGuarder._4A1A3578,
		EXGuarder._65513B0C,
		EXGuarder._43214E5C,
		EXGuarder._2A346A05,
		EXGuarder._696D0748,
		EXGuarder._4A554168,
		EXGuarder._72095E2B,
		EXGuarder._6A5A0B59,
		EXGuarder._3F2D0635,
		EXGuarder._4C6B7115,
		EXGuarder._1C6F7269,
		EXGuarder._3572695D,
		EXGuarder._61207505,
		EXGuarder._282F272F,
		EXGuarder._25342544,
		EXGuarder._540B5B76,
		EXGuarder._52086D5E,
		EXGuarder._1F231A61,
		EXGuarder._6C013A33,
		EXGuarder._760C062E,
		EXGuarder._5369655C,
		EXGuarder._4B5C2976,
		EXGuarder._0161403B,
		EXGuarder._1867483F,
		EXGuarder._343E685A,
		EXGuarder._2E6B016E,
		EXGuarder._3B55344A,
		EXGuarder._2A073952,
		EXGuarder._68585B04,
		EXGuarder._2F305D6D,
		EXGuarder._62136E1F,
		EXGuarder._0B3B0C28,
		EXGuarder._493A5526,
		EXGuarder._5A12500B,
		EXGuarder._3B22134B,
		EXGuarder._3F787939,
		EXGuarder._782C3A08,
		EXGuarder._0C3A2A75,
		EXGuarder._2F216D59,
		EXGuarder._16445841,
		EXGuarder._330D2413,
		EXGuarder._482B7104,
		EXGuarder._30183C07,
		EXGuarder._72016A3A,
		EXGuarder._39447049,
		EXGuarder._64395338,
		EXGuarder._0F010C2D,
		EXGuarder._33437803,
		EXGuarder._53582A17,
		EXGuarder._711D5216,
		EXGuarder._143E2B16,
		EXGuarder._1B047431,
		EXGuarder._362F2442,
		EXGuarder._1823573C,
		EXGuarder._55172955,
		EXGuarder._6B16412C,
		EXGuarder._5C34420F,
		EXGuarder._4E3D1818,
		EXGuarder._60241829,
		EXGuarder._580F2001,
		EXGuarder._42297874,
		EXGuarder._7811473D,
		EXGuarder._4B076D00,
		EXGuarder._74052504,
		EXGuarder._423D2036,
		EXGuarder._1F5B706D,
		EXGuarder._120F792E,
		EXGuarder._5258066B,
		EXGuarder._4F21085A,
		EXGuarder._5C42494B,
		EXGuarder._3E655A14,
		EXGuarder._36286165,
		EXGuarder._00400413,
		EXGuarder._2A350612,
		EXGuarder._3E276B03,
		EXGuarder._5A19103C,
		EXGuarder._59172479,
		EXGuarder._3E39070B,
		EXGuarder._684A385E,
		EXGuarder._453C5645,
		EXGuarder._29602D48,
		EXGuarder._29235824,
		EXGuarder._026F6559,
		EXGuarder._1F6A572F,
		EXGuarder._44522F64,
		EXGuarder._6C751F06,
		EXGuarder._1A315C4A,
		EXGuarder._5A35416C,
		EXGuarder._3A084717,
		EXGuarder._3E763179,
		EXGuarder._716C5533,
		EXGuarder._0F604F22,
		EXGuarder._2A0C4C1C,
		EXGuarder._53316175,
		EXGuarder._3F2C716C,
		EXGuarder._10061661,
		EXGuarder._4342063A,
		EXGuarder._40514800,
		EXGuarder._7479236D,
		EXGuarder._245C1B14,
		EXGuarder._09346F18,
		EXGuarder._1C582205,
		EXGuarder._6E18130D,
		EXGuarder._3E2C4370,
		EXGuarder._2B1D5918,
		EXGuarder._76191A52,
		EXGuarder._321D3079,
		EXGuarder._79382C1A,
		EXGuarder._202B455D,
		EXGuarder._00345C4C,
		EXGuarder._544B294B,
		EXGuarder._14562656,
		EXGuarder._3B220763,
		EXGuarder._33292249,
		EXGuarder._5B6A4467,
		EXGuarder._43147215,
		EXGuarder._4729420C,
		EXGuarder._0E4B6478,
		EXGuarder._5D411D5A,
		EXGuarder._100C7810,
		EXGuarder._6B693E01,
		EXGuarder._4B370F76,
		EXGuarder._2A731B30,
		EXGuarder._601E3755,
		EXGuarder._2759792B,
		EXGuarder._3B330243,
		EXGuarder._4D171847,
		EXGuarder._6B4F686E,
		EXGuarder._70336321,
		EXGuarder._5039264E,
		EXGuarder._69561A43,
		EXGuarder._1F6C0128,
		EXGuarder._366B1414,
		EXGuarder._6F370651,
		EXGuarder._7870262F,
		EXGuarder._6E351956,
		EXGuarder._3C6C0C5F,
		EXGuarder._376B3A12,
		EXGuarder._6A155B37,
		EXGuarder._3D4F435B,
		EXGuarder._5E4C6F24,
		EXGuarder._79590B17,
		EXGuarder._424C6F27,
		EXGuarder._0D523618,
		EXGuarder._50092D72,
		EXGuarder._46620152,
		EXGuarder._640A601E,
		EXGuarder._466A1513,
		EXGuarder._5256475D,
		EXGuarder._4E5C7166,
		EXGuarder._57731332,
		EXGuarder._0B24791D,
		EXGuarder._72371F1F,
		EXGuarder._2746515C,
		EXGuarder._05140E65,
		EXGuarder._01341B21,
		EXGuarder._5F0D401F,
		EXGuarder._1476624B,
		EXGuarder._50304B77,
		EXGuarder._59407901,
		EXGuarder._1A204562,
		EXGuarder._700D186C,
		EXGuarder._276D0E35,
		EXGuarder._281E552B,
		EXGuarder._3820744C,
		EXGuarder._6D503A12,
		EXGuarder._433E243B,
		EXGuarder._7878210E,
		EXGuarder._2D211061,
		EXGuarder._60722A3F,
		EXGuarder._106F6B73,
		EXGuarder._03541164,
		EXGuarder._5B447336,
		EXGuarder._4F78602F,
		EXGuarder._3E114F08,
		EXGuarder._6B14361C,
		EXGuarder._3003380B,
		EXGuarder._386D7529,
		EXGuarder._71581C09,
		EXGuarder._325A6A03,
		EXGuarder._0220504B,
		EXGuarder._770C0025,
		EXGuarder._476A112C,
		EXGuarder._2863330B,
		EXGuarder._27473958,
		EXGuarder._20477311,
		EXGuarder._2F016348,
		EXGuarder._2855036E,
		EXGuarder._221C0237,
		EXGuarder._64551242,
		EXGuarder._28075164,
		EXGuarder._23000574,
		EXGuarder._27563128,
		EXGuarder._1E4E3C1D,
		EXGuarder._26350A69,
		EXGuarder._29030F49,
		EXGuarder._17033713,
		EXGuarder._79273549,
		EXGuarder._0C18205A,
		EXGuarder._10411158,
		EXGuarder._303F400B,
		EXGuarder._1653425F,
		EXGuarder._3D056D54,
		EXGuarder._20623869,
		EXGuarder._3C484736,
		EXGuarder._2B006717,
		EXGuarder._21514535,
		EXGuarder._436E0D0D,
		EXGuarder._2727695C,
		EXGuarder._17210C09,
		EXGuarder._15630C45,
		EXGuarder._2E420808,
		EXGuarder._4E735C30,
		EXGuarder._23595E57,
		EXGuarder._72040D76,
		EXGuarder._16023275,
		EXGuarder._14502D20,
		EXGuarder._03372379,
		EXGuarder._33743855,
		EXGuarder._331A714C,
		EXGuarder._2E1B7008,
		EXGuarder._0D620120,
		EXGuarder._4307685D,
		EXGuarder._235C0079,
		EXGuarder._0B631938,
		EXGuarder._1A72632A,
		EXGuarder._5A2D2D1F,
		EXGuarder._5448303B,
		EXGuarder._53340D11,
		EXGuarder._631A0A19,
		EXGuarder._4C716374,
		EXGuarder._48205677,
		EXGuarder._2F6E3E1F,
		EXGuarder._6C5B703D,
		EXGuarder._71125534,
		EXGuarder._03612B11,
		EXGuarder._3B110D16,
		EXGuarder._63114F30,
		EXGuarder._3C6A0E0E,
		EXGuarder._386E1C6B,
		EXGuarder._35011B3A,
		EXGuarder._571D244F
	};

	private static Random Rndomizid;

	private static string[] randmid3 = new string[165]
	{
		EXGuarder._79524325,
		EXGuarder._3A353E0F,
		EXGuarder._230A6973,
		EXGuarder._215E603A,
		EXGuarder._6B14361C,
		EXGuarder._4A683458,
		EXGuarder._1C582205,
		EXGuarder._516A6547,
		EXGuarder._08485F58,
		EXGuarder._2A346A05,
		EXGuarder._6C37421F,
		EXGuarder._79273549,
		EXGuarder._5742305A,
		EXGuarder._221E3961,
		EXGuarder._08426828,
		EXGuarder._135F5873,
		EXGuarder._7645220A,
		EXGuarder._2E680E63,
		EXGuarder._33123C72,
		EXGuarder._1B05306B,
		EXGuarder._532D181E,
		EXGuarder._3360414D,
		EXGuarder._423C4315,
		EXGuarder._105A2A60,
		EXGuarder._6A72536C,
		EXGuarder._29030F49,
		EXGuarder._531B506C,
		EXGuarder._0E4E5D60,
		EXGuarder._39487745,
		EXGuarder._58681668,
		EXGuarder._285C5828,
		EXGuarder._2D467940,
		EXGuarder._72040D76,
		EXGuarder._57456D29,
		EXGuarder._49456624,
		EXGuarder._31492E36,
		EXGuarder._60722A3F,
		EXGuarder._65007162,
		EXGuarder._2A680649,
		EXGuarder._3E000F08,
		EXGuarder._43792D39,
		EXGuarder._3E114F08,
		EXGuarder._0F22034F,
		EXGuarder._500A7675,
		EXGuarder._17085465,
		EXGuarder._70336321,
		EXGuarder._0C5A7914,
		EXGuarder._3D2A273A,
		EXGuarder._021F7933,
		EXGuarder._2F212B55,
		EXGuarder._50254E1D,
		EXGuarder._624A122C,
		EXGuarder._5573503F,
		EXGuarder._762F6273,
		EXGuarder._2927533A,
		EXGuarder._70242F64,
		EXGuarder._0E733C21,
		EXGuarder._67014708,
		EXGuarder._5E0F7653,
		EXGuarder._79590B17,
		EXGuarder._5832062A,
		EXGuarder._105D1057,
		EXGuarder._58186E21,
		EXGuarder._060C5104,
		EXGuarder._0D544E07,
		EXGuarder._47296867,
		EXGuarder._46106C21,
		EXGuarder._34206E5A,
		EXGuarder._31794E06,
		EXGuarder._38054E26,
		EXGuarder._17190011,
		EXGuarder._3E767213,
		EXGuarder._61207505,
		EXGuarder._04512752,
		EXGuarder._741A7444,
		EXGuarder._743E6108,
		EXGuarder._6173311F,
		EXGuarder._3E51705B,
		EXGuarder._35117137,
		EXGuarder._54456A3F,
		EXGuarder._19395F54,
		EXGuarder._34232F51,
		EXGuarder._3D4F435B,
		EXGuarder._1A167622,
		EXGuarder._6E290413,
		EXGuarder._0841320E,
		EXGuarder._26581D17,
		EXGuarder._32140019,
		EXGuarder._571B3073,
		EXGuarder._11342368,
		EXGuarder._5128451E,
		EXGuarder._4A554168,
		EXGuarder._0866415B,
		EXGuarder._22753778,
		EXGuarder._61524573,
		EXGuarder._7811473D,
		EXGuarder._3D056D54,
		EXGuarder._70336321,
		EXGuarder._504C266C,
		EXGuarder._2A291462,
		EXGuarder._6B161866,
		EXGuarder._134A0F35,
		EXGuarder._6B585254,
		EXGuarder._17210C09,
		EXGuarder._09685561,
		EXGuarder._78381853,
		EXGuarder._5427642E,
		EXGuarder._720D7943,
		EXGuarder._12137000,
		EXGuarder._370E1F70,
		EXGuarder._6D503A12,
		EXGuarder._1857776F,
		EXGuarder._10711C0C,
		EXGuarder._555C4D24,
		EXGuarder._43214E5C,
		EXGuarder._52073423,
		EXGuarder._2A731B30,
		EXGuarder._235C0079,
		EXGuarder._6F200C64,
		EXGuarder._662F6D5B,
		EXGuarder._4C262903,
		EXGuarder._2420425B,
		EXGuarder._5026746C,
		EXGuarder._612A3655,
		EXGuarder._4E3B6114,
		EXGuarder._064B1143,
		EXGuarder._5F712D32,
		EXGuarder._5F0D401F,
		EXGuarder._435C703F,
		EXGuarder._192B1D72,
		EXGuarder._56205704,
		EXGuarder._626D7720,
		EXGuarder._5B35043D,
		EXGuarder._70242F64,
		EXGuarder._4F751E74,
		EXGuarder._37305253,
		EXGuarder._253E0863,
		EXGuarder._05420A56,
		EXGuarder._33743855,
		EXGuarder._5C215104,
		EXGuarder._5A697922,
		EXGuarder._60385278,
		EXGuarder._24605504,
		EXGuarder._6E0C1F1D,
		EXGuarder._1849292D,
		EXGuarder._3B795F3A,
		EXGuarder._6E51714A,
		EXGuarder._0766381D,
		EXGuarder._556B0654,
		EXGuarder._14720753,
		EXGuarder._49220831,
		EXGuarder._636C5E62,
		EXGuarder._6A793D44,
		EXGuarder._32194C1C,
		EXGuarder._610A444D,
		EXGuarder._42636658,
		EXGuarder._611A763D,
		EXGuarder._47770808,
		EXGuarder._093A0479,
		EXGuarder._67474073,
		EXGuarder._4C5E5648,
		EXGuarder._0074450E,
		EXGuarder._2E361D2E,
		EXGuarder._66475B19,
		EXGuarder._4A1A3578
	};

	private static Random Rndomizid3;

	private static string[] randmid4 = new string[180]
	{
		EXGuarder._215E603A,
		EXGuarder._0174416F,
		EXGuarder._04602320,
		EXGuarder._5B6A4467,
		EXGuarder._79524325,
		EXGuarder._2D530076,
		EXGuarder._5C42494B,
		EXGuarder._1B344972,
		EXGuarder._38610027,
		EXGuarder._0C5A7914,
		EXGuarder._1F6A572F,
		EXGuarder._1673406C,
		EXGuarder._436A096C,
		EXGuarder._48197717,
		EXGuarder._3E2C4370,
		EXGuarder._014B7852,
		EXGuarder._6B446455,
		EXGuarder._17085465,
		EXGuarder._1D206703,
		EXGuarder._0A19252A,
		EXGuarder._751B1603,
		EXGuarder._11673109,
		EXGuarder._4746415C,
		EXGuarder._0B236E0B,
		EXGuarder._196A4655,
		EXGuarder._415D253A,
		EXGuarder._4D497150,
		EXGuarder._56461601,
		EXGuarder._784A2647,
		EXGuarder._57456D29,
		EXGuarder._105B5964,
		EXGuarder._26581D17,
		EXGuarder._19100F45,
		EXGuarder._10546401,
		EXGuarder._272B4720,
		EXGuarder._17110A01,
		EXGuarder._6D447638,
		EXGuarder._35546646,
		EXGuarder._450D4F27,
		EXGuarder._7811473D,
		EXGuarder._4B076D00,
		EXGuarder._5A35416C,
		EXGuarder._1D0D614A,
		EXGuarder._1F4A3053,
		EXGuarder._65026744,
		EXGuarder._2F212B55,
		EXGuarder._6402764B,
		EXGuarder._3360414D,
		EXGuarder._6D40635A,
		EXGuarder._3A353E0F,
		EXGuarder._2B57402C,
		EXGuarder._0C0F5A56,
		EXGuarder._4342063A,
		EXGuarder._56670F76,
		EXGuarder._343E685A,
		EXGuarder._1857776F,
		EXGuarder._4A1A3578,
		EXGuarder._7479236D,
		EXGuarder._2F4B7834,
		EXGuarder._75293829,
		EXGuarder._2A680649,
		EXGuarder._622E4658,
		EXGuarder._14172F3F,
		EXGuarder._5A12500B,
		EXGuarder._42297874,
		EXGuarder._38781F30,
		EXGuarder._053A333A,
		EXGuarder._79382C1A,
		EXGuarder._6F506538,
		EXGuarder._3A084717,
		EXGuarder._48703D3A,
		EXGuarder._14562656,
		EXGuarder._6F706341,
		EXGuarder._075E6212,
		EXGuarder._00115571,
		EXGuarder._43147215,
		EXGuarder._4729420C,
		EXGuarder._2E1C6E37,
		EXGuarder._4D6E5173,
		EXGuarder._5E0F7653,
		EXGuarder._5A19103C,
		EXGuarder._59172479,
		EXGuarder._59132D27,
		EXGuarder._6B693E01,
		EXGuarder._2A346A05,
		EXGuarder._3507462D,
		EXGuarder._601E3755,
		EXGuarder._2759792B,
		EXGuarder._3B330243,
		EXGuarder._3F2D0635,
		EXGuarder._4D171847,
		EXGuarder._6B4F686E,
		EXGuarder._70336321,
		EXGuarder._5039264E,
		EXGuarder._2E6C201A,
		EXGuarder._50595315,
		EXGuarder._5902112D,
		EXGuarder._62110174,
		EXGuarder._7870262F,
		EXGuarder._6E351956,
		EXGuarder._22014209,
		EXGuarder._376B3A12,
		EXGuarder._6A155B37,
		EXGuarder._3D4F435B,
		EXGuarder._34796A44,
		EXGuarder._48253D37,
		EXGuarder._173A7134,
		EXGuarder._5A043C2E,
		EXGuarder._4307685D,
		EXGuarder._746E7433,
		EXGuarder._2317180B,
		EXGuarder._05353331,
		EXGuarder._1E77294B,
		EXGuarder._321D3079,
		EXGuarder._1E753201,
		EXGuarder._14081F13,
		EXGuarder._61207505,
		EXGuarder._1B37720B,
		EXGuarder._1F6C0128,
		EXGuarder._366B1414,
		EXGuarder._74120030,
		EXGuarder._192B1D72,
		EXGuarder._35117137,
		EXGuarder._03167812,
		EXGuarder._2E59212A,
		EXGuarder._076C5875,
		EXGuarder._12137000,
		EXGuarder._77145622,
		EXGuarder._1104483D,
		EXGuarder._16377964,
		EXGuarder._1B0E134B,
		EXGuarder._1B680848,
		EXGuarder._6B585D36,
		EXGuarder._6D4A5030,
		EXGuarder._05794E23,
		EXGuarder._5B4B6F09,
		EXGuarder._29230A49,
		EXGuarder._51555A13,
		EXGuarder._3004121E,
		EXGuarder._0F0F064E,
		EXGuarder._710D703F,
		EXGuarder._4E267621,
		EXGuarder._68667971,
		EXGuarder._3C565E74,
		EXGuarder._54440610,
		EXGuarder._77724512,
		EXGuarder._0E52261F,
		EXGuarder._116C3967,
		EXGuarder._53316175,
		EXGuarder._38545911,
		EXGuarder._21492D42,
		EXGuarder._3A533100,
		EXGuarder._516A6547,
		EXGuarder._6A6D3778,
		EXGuarder._4533390C,
		EXGuarder._2655194F,
		EXGuarder._3E302F12,
		EXGuarder._66756E49,
		EXGuarder._0F565025,
		EXGuarder._100B1315,
		EXGuarder._22763740,
		EXGuarder._4A0D0665,
		EXGuarder._7230176C,
		EXGuarder._50084164,
		EXGuarder._1E753201,
		EXGuarder._1D5A4933,
		EXGuarder._6B2A3330,
		EXGuarder._24781643,
		EXGuarder._6B161866,
		EXGuarder._10697173,
		EXGuarder._3E162368,
		EXGuarder._70082478,
		EXGuarder._3F09142F,
		EXGuarder._15490272,
		EXGuarder._720D7943,
		EXGuarder._4C417803,
		EXGuarder._6A72536C,
		EXGuarder._14502D20,
		EXGuarder._79590B17,
		EXGuarder._10711C0C
	};

	[SpecialName]
	private static long _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init;

	[SpecialName]
	private static long _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init;

	public static async Task<string> TranslateAsync(string inputtext, string fromlangid, string tolangid)
	{
		try
		{
			if (Operators.CompareString(tolangid.ToUpper(), "EN", TextCompare: false) == 0)
			{
				return inputtext;
			}
			if (Operators.CompareString(tolangid.ToUpper(), "CN", TextCompare: false) == 0)
			{
				tolangid = "zh";
			}
			inputtext = Uri.EscapeDataString(inputtext.Replace("\r\n", "[]"));
			string requestUri = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl={tolangid}&hl={fromlangid}&dt=t&dt=bd&dj=1&source=icon&q={inputtext}";
			using HttpClient httpClient = new HttpClient();
			httpClient.Timeout = TimeSpan.FromSeconds(5.0);
			string text = await httpClient.GetStringAsync(requestUri);
			if (string.IsNullOrWhiteSpace(text) || !text.Trim().StartsWith("{"))
			{
				return GetNetworkErrorMessage(tolangid);
			}
			JObject jObject = JObject.Parse(text);
			JToken jToken = jObject.SelectToken("sentences[0].trans");
			if (jToken == null)
			{
				return GetNetworkErrorMessage(tolangid);
			}
			string text2 = jToken.ToString();
			return text2.Replace("[]", "\r\n");
		}
		catch (TaskCanceledException projectError)
		{
			ProjectData.SetProjectError(projectError);
			string networkErrorMessage = GetNetworkErrorMessage(tolangid);
			ProjectData.ClearProjectError();
			return networkErrorMessage;
		}
		catch (HttpRequestException projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			string networkErrorMessage = GetNetworkErrorMessage(tolangid);
			ProjectData.ClearProjectError();
			return networkErrorMessage;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			string networkErrorMessage = GetNetworkErrorMessage(tolangid);
			ProjectData.ClearProjectError();
			return networkErrorMessage;
		}
	}

	private static string GetNetworkErrorMessage(string lang)
	{
		string left = lang.ToLower();
		if (Operators.CompareString(left, EXGuarder._2F62536E, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._770B1950, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._3330584E, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._4D522E54, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._5E2B2E03, TextCompare: false) != 0)
						{
							if (Operators.CompareString(left, EXGuarder._21122153, TextCompare: false) == 0)
							{
								return EXGuarder._3F747856;
							}
							return EXGuarder._6814215D;
						}
						return EXGuarder._10471723;
					}
					return EXGuarder._44152C62;
				}
				return EXGuarder._2E724646;
			}
			return EXGuarder._556A3E02;
		}
		return EXGuarder._541E5F0C;
	}

	public static Bitmap GetImageFromUrl(string url)
	{
		Bitmap result;
		try
		{
			if (!url.StartsWith(EXGuarder._39320A33) && !url.StartsWith(EXGuarder._322F5A5B))
			{
				url = EXGuarder._39320A33 + url;
			}
			WebClient webClient = new WebClient();
			Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream(webClient.DownloadData(url)));
			result = bitmap;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debuger.Log_e(EXGuarder._2E284D28, EXtoString(ex2));
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string EXtoString(Exception ex)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string arg = DateTime.Now.ToString(EXGuarder._1D785C45);
		string sep = EXGuarder._42101117;
		stringBuilder.AppendLine(string.Format(EXGuarder._2B030C25, arg));
		stringBuilder.AppendLine(EXGuarder._22332426);
		stringBuilder.AppendLine();
		try
		{
			if (ex != null)
			{
				stringBuilder.AppendLine(EXGuarder._661B1B1F);
				stringBuilder.AppendLine(ex.Message ?? EXGuarder._7520071A);
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(EXGuarder._0E617976);
				stringBuilder.AppendLine(ex.StackTrace ?? EXGuarder._7520071A);
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(EXGuarder._1A02450B);
				stringBuilder.AppendLine(ex.InnerException?.Message ?? EXGuarder._7520071A);
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(EXGuarder._1C43675A);
				stringBuilder.AppendLine(ex.InnerException?.StackTrace ?? EXGuarder._7520071A);
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(EXGuarder._404F6467);
				try
				{
					if (ex.Data != null && ex.Data.Count > 0)
					{
						foreach (object key in ex.Data.Keys)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(key);
							stringBuilder.AppendLine(string.Format(EXGuarder._6E5F6758, RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(ex.Data[RuntimeHelpers.GetObjectValue(objectValue)])));
						}
					}
					else
					{
						stringBuilder.AppendLine(EXGuarder._0056792A);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					stringBuilder.AppendLine(EXGuarder._755C7575);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				stringBuilder.AppendLine(EXGuarder._6A501B23);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			stringBuilder.AppendLine(EXGuarder._4C1D102A);
			ProjectData.ClearProjectError();
		}
		return stringBuilder.ToString();
	}

	public static long TcpPing(string ipAddress, int port, int timeoutMillis)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		long result;
		try
		{
			using (TcpClient tcpClient = new TcpClient())
			{
				tcpClient.ReceiveTimeout = timeoutMillis;
				tcpClient.SendTimeout = timeoutMillis;
				tcpClient.Connect(ipAddress, port);
			}
			stopwatch.Stop();
			result = stopwatch.ElapsedMilliseconds;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = 0L;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static Image ResizeImage(Image inputImage, Size size, bool preserveAspectRatio = false)
	{
		if (inputImage.Width == size.Width && inputImage.Height == size.Height)
		{
			return new Bitmap(inputImage);
		}
		int width = size.Width;
		int height = size.Height;
		checked
		{
			if (preserveAspectRatio)
			{
				int width2 = inputImage.Width;
				int height2 = inputImage.Height;
				float num = (float)Math.Min((double)size.Width / (double)width2, (double)size.Height / (double)height2);
				width = (int)Math.Round((float)width2 * num);
				height = (int)Math.Round((float)height2 * num);
			}
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(inputImage, 0, 0, width, height);
			}
			return bitmap;
		}
	}

	public static bool IsPngImage(string filePath)
	{
		bool result;
		try
		{
			using Image image = Image.FromFile(filePath);
			result = image.RawFormat.Guid == ImageFormat.Png.Guid;
		}
		catch (OutOfMemoryException ex)
		{
			ProjectData.SetProjectError(ex);
			OutOfMemoryException ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		catch (FileNotFoundException ex3)
		{
			ProjectData.SetProjectError(ex3);
			FileNotFoundException ex4 = ex3;
			result = false;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ToBase64(string Str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Str);
		return Convert.ToBase64String(bytes);
	}

	public static string FromBase64(string Str)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(Str));
	}

	public static Image Base64ToImage(string base64string)
	{
		string s = base64string.Replace(EXGuarder._765A4F2D, EXGuarder._24466D10);
		byte[] buffer = Convert.FromBase64String(s);
		MemoryStream memoryStream = new MemoryStream(buffer);
		Image result = Image.FromStream(memoryStream);
		memoryStream.Dispose();
		return result;
	}

	public static int CalculateBufferSize(long totalBytes)
	{
		if (totalBytes < 1048576)
		{
			return 65536;
		}
		if (totalBytes < 10485760)
		{
			return 262144;
		}
		return 1048576;
	}

	public static string CalculateMD5(string filePath)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(filePath);
		byte[] array = mD.ComputeHash(inputStream);
		return BitConverter.ToString(array).Replace(EXGuarder._1A212350, EXGuarder._7841553B).ToLower();
	}

	public static string GetMD5Hash(string filePath)
	{
		string result;
		try
		{
			using MD5 mD = MD5.Create();
			using FileStream inputStream = File.OpenRead(filePath);
			byte[] array = mD.ComputeHash(inputStream);
			result = BitConverter.ToString(array).Replace(EXGuarder._3B263020, EXGuarder._3C022345).ToLower();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = EXGuarder._3F711F27 + ex2.Message;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool StrisEmpty(string str)
	{
		if (string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
		{
			return true;
		}
		return false;
	}

	public static string StrGenerator(int maxlength)
	{
		if (r == null)
		{
			r = new Random();
		}
		string _0C1C2D6B = EXGuarder._0C1C2D6B;
		string text = EXGuarder._640D5302;
		do
		{
			text += _0C1C2D6B[r.Next(0, _0C1C2D6B.Length)];
		}
		while (text.Length < maxlength);
		return text;
	}

	public static string StringToMD5(string input)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString(EXGuarder._07142F74));
		}
		return stringBuilder.ToString();
	}

	public static string GetHWID()
	{
		string empty;
		if (lasthwid != null)
		{
			empty = lasthwid;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				string arg = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
				try
				{
					ManagementObject managementObject = new ManagementObject(string.Format(EXGuarder._79043359, arg));
					managementObject.Get();
					string text = Conversions.ToString(managementObject[EXGuarder._413C4C11]);
					stringBuilder.Append((text != null) ? text.ToString() : EXGuarder._10075662);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					stringBuilder.Append(EXGuarder._10075662);
					ProjectData.ClearProjectError();
				}
				try
				{
					using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(EXGuarder._0D212554);
					foreach (ManagementObject item in managementObjectSearcher.Get())
					{
						string text2 = Conversions.ToString(item[EXGuarder._33055308]);
						stringBuilder.Append((text2 != null) ? text2.ToString() : EXGuarder._3305412D);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					stringBuilder.Append(EXGuarder._3305412D);
					ProjectData.ClearProjectError();
				}
				try
				{
					using ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher(EXGuarder._132C1924);
					foreach (ManagementObject item2 in managementObjectSearcher2.Get())
					{
						string text3 = Conversions.ToString(item2[EXGuarder._013D2C1D]);
						stringBuilder.Append((text3 != null) ? text3.ToString() : EXGuarder._6300210A);
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					stringBuilder.Append(EXGuarder._6300210A);
					ProjectData.ClearProjectError();
				}
				lasthwid = stringBuilder.ToString().Trim().Replace(EXGuarder._13723225, EXGuarder._77031C0E);
				empty = lasthwid;
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				Interaction.MsgBox(EXGuarder._16186E13);
				Environment.FailFast(EXGuarder._16186E13);
				empty = string.Empty;
				ProjectData.ClearProjectError();
			}
		}
		return empty;
	}

	public static Bitmap Base64ToBitmap(string base64String)
	{
		byte[] buffer = Convert.FromBase64String(base64String);
		using MemoryStream stream = new MemoryStream(buffer);
		return new Bitmap(stream);
	}

	public static void SaveVideothumb(string thumbs, string Filename, Image img)
	{
		try
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Filename);
			string text = Path.Combine(thumbs, fileNameWithoutExtension);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string path = fileNameWithoutExtension + EXGuarder._1755292E + DateTime.Now.Millisecond + EXGuarder._6E0A2423;
			string filename = Path.Combine(text, path);
			img.Save(filename);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
	}

	public static Bitmap ReadBitmapFromFile(string s_Path)
	{
		Bitmap result;
		try
		{
			using FileStream stream = new FileStream(s_Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			using Bitmap original = new Bitmap(stream);
			result = new Bitmap(original);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = new Bitmap(4, 4);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int RateConverter(int Value, int Totalsize)
	{
		int result;
		try
		{
			result = ((Totalsize != 0) ? checked((int)Math.Round((double)Value / (double)Totalsize * 100.0)) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = 0;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string[] BytesConverter(long bytes)
	{
		string text = ((bytes >= 1099511627776L) ? (((double)bytes / 1099511627776.0).ToString(EXGuarder._4C130605) + EXGuarder._701E226C) : ((bytes >= 1073741824) ? (((double)bytes / 1073741824.0).ToString(EXGuarder._4C130605) + EXGuarder._546F4553) : ((bytes >= 1048576) ? (((double)bytes / 1048576.0).ToString(EXGuarder._4C130605) + EXGuarder._33253F4E) : ((bytes < 1024) ? (Conversions.ToString(bytes) + EXGuarder._00362931) : (((double)bytes / 1024.0).ToString(EXGuarder._4C130605) + EXGuarder._4157412C)))));
		return new string[1] { text };
	}

	public static string BytesToText(long bytes)
	{
		if (bytes >= 1099511627776L)
		{
			return ((double)bytes / 1099511627776.0).ToString(EXGuarder._29427837) + EXGuarder._4B085267;
		}
		if (bytes >= 1073741824)
		{
			return ((double)bytes / 1073741824.0).ToString(EXGuarder._29427837) + EXGuarder._5C0E1E1A;
		}
		if (bytes >= 1048576)
		{
			return ((double)bytes / 1048576.0).ToString(EXGuarder._29427837) + EXGuarder._72774433;
		}
		if (bytes >= 1024)
		{
			return ((double)bytes / 1024.0).ToString(EXGuarder._29427837) + EXGuarder._0F266B47;
		}
		return Conversions.ToString(bytes) + EXGuarder._53066B2F;
	}

	public static Array UploadDownload(long ParametersLong0, long ParametersLong1)
	{
		checked
		{
			Array result;
			try
			{
				if (_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init == null)
				{
					Interlocked.CompareExchange(ref _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init, new StaticLocalInitFlag(), null);
				}
				bool lockTaken = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init, ref lockTaken);
					if (_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init.State == 0)
					{
						_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init.State = 2;
						_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload = ParametersLong0;
					}
					else if (_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init.State = 1;
					if (lockTaken)
					{
						Monitor.Exit(_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload_0024Init);
					}
				}
				if (_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init == null)
				{
					Interlocked.CompareExchange(ref _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init, new StaticLocalInitFlag(), null);
				}
				bool lockTaken2 = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init, ref lockTaken2);
					if (_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init.State == 0)
					{
						_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init.State = 2;
						_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload = ParametersLong1;
					}
					else if (_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init.State = 1;
					if (lockTaken2)
					{
						Monitor.Exit(_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload_0024Init);
					}
				}
				long num = ParametersLong0 - _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload;
				long num2 = ParametersLong1 - _0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload;
				_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastUpload = ParametersLong0;
				_0024STATIC_0024UploadDownload_0024021281B5AA_0024LastDownload = ParametersLong1;
				result = new object[2]
				{
					BytesConverter((num2 < 0) ? 0 : num2).GetValue(0),
					BytesConverter((num < 0) ? 0 : num).GetValue(0)
				};
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = new string[2]
				{
					EXGuarder._5A5D5F5F,
					EXGuarder._5A5D5F5F
				};
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static void PlayNotificationSound()
	{
		try
		{
			string text = Conversions.ToString(BTRegistry.GetValue(EXGuarder._5373655B, EXGuarder._53745A15));
			string uRL = MyRes.Sounds_Path + EXGuarder._712D6C6F + text + EXGuarder._62157942;
			WindowsMediaPlayer windowsMediaPlayer = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid(EXGuarder._596C4404)));
			windowsMediaPlayer.URL = uRL;
			windowsMediaPlayer.controls.play();
			windowsMediaPlayer.settings.volume = 100;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(EXGuarder._02760623 + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void SaveWavFile(List<byte[]> buffers, string outputPath)
	{
		try
		{
			byte[] bytes = ConcatenateAudioBuffers(buffers);
			File.WriteAllBytes(outputPath, bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debuger.Log_e(EXGuarder._3D46385B, EXtoString(ex2));
			Console.WriteLine(EXGuarder._66754535 + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private static byte[] ConcatenateAudioBuffers(List<byte[]> buffers)
	{
		int num = 44;
		checked
		{
			int num2 = buffers.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = ((i != 0) ? (num + (buffers[i].Length - 44)) : (num + buffers[i].Length));
			}
			byte[] array = new byte[num - 1 + 1];
			int num3 = 0;
			int num4 = buffers.Count - 1;
			for (int j = 0; j <= num4; j++)
			{
				byte[] array2 = buffers[j];
				if (j == 0)
				{
					Buffer.BlockCopy(array2, 0, array, num3, array2.Length);
					num3 += array2.Length;
				}
				else
				{
					Buffer.BlockCopy(array2, 44, array, num3, array2.Length - 44);
					num3 += array2.Length - 44;
				}
			}
			int value = num - 8;
			int value2 = num - 44;
			BitConverter.GetBytes(value).CopyTo(array, 4);
			BitConverter.GetBytes(value2).CopyTo(array, 40);
			return array;
		}
	}

	public static void SaveDGV(DataGridView DGVNUMS, string Clifolder, string savetype)
	{
		if (DGVNUMS.Rows.Count > 0)
		{
			string text = Clifolder + EXGuarder._4B2F4176 + savetype;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = savetype + EXGuarder._6F424B00;
			text2 = text + EXGuarder._4B2F4176 + text2.Replace(EXGuarder._6F424B00, EXGuarder._791A122C + DateTime.Now.ToString(EXGuarder._3A3D2422) + EXGuarder._6F424B00);
			File.WriteAllText(text2, DataGridToHTML(DGVNUMS));
		}
	}

	public static void SaveJson(string jsonstr, string Clifolder, string savetype, string FilTag)
	{
		try
		{
			string text = Clifolder + EXGuarder._71676100 + savetype;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = FilTag + EXGuarder._774B774A;
			text2 = text + EXGuarder._71676100 + text2.Replace(EXGuarder._774B774A, EXGuarder._24795400 + DateTime.Now.ToString(EXGuarder._1D674967) + EXGuarder._774B774A);
			File.WriteAllText(text2, jsonstr);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static string DataGridToHTML(DataGridView dg)
	{
		if (dg == null || dg.Rows.Count == 0)
		{
			return EXGuarder._2E343214;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(EXGuarder._383E462F);
		stringBuilder.AppendLine(EXGuarder._696D1D12);
		stringBuilder.AppendLine(EXGuarder._0B733358);
		stringBuilder.AppendLine(EXGuarder._44443429);
		stringBuilder.AppendLine(EXGuarder._065C786E);
		stringBuilder.AppendLine(EXGuarder._3B001E28);
		foreach (DataGridViewColumn column in dg.Columns)
		{
			if (column.Visible)
			{
				stringBuilder.AppendLine(string.Format(EXGuarder._43450F1B, HttpUtility.HtmlEncode(column.HeaderText)));
			}
		}
		stringBuilder.AppendLine(EXGuarder._0353255B);
		stringBuilder.AppendLine(EXGuarder._453A543D);
		stringBuilder.AppendLine(EXGuarder._36611A38);
		foreach (DataGridViewRow item in (IEnumerable)dg.Rows)
		{
			if (item.IsNewRow)
			{
				continue;
			}
			stringBuilder.AppendLine(EXGuarder._3B001E28);
			foreach (DataGridViewCell cell in item.Cells)
			{
				if (cell.Visible)
				{
					string s = ((cell.Value != null) ? cell.Value.ToString() : string.Empty);
					stringBuilder.AppendLine(string.Format(EXGuarder._2A0F0E10, HttpUtility.HtmlEncode(s)));
				}
			}
			stringBuilder.AppendLine(EXGuarder._0353255B);
		}
		stringBuilder.AppendLine(EXGuarder._5D702E39);
		stringBuilder.AppendLine(EXGuarder._305C7971);
		stringBuilder.AppendLine(EXGuarder._7704152F);
		stringBuilder.AppendLine(EXGuarder._166B4E24);
		stringBuilder.AppendLine(EXGuarder._0A343946);
		return stringBuilder.ToString();
	}

	public static Bitmap SafeCloneImage(Image src)
	{
		if (src == null)
		{
			Bitmap bitmap = new Bitmap(1, 1);
			bitmap.SetPixel(0, 0, Color.Transparent);
			return bitmap;
		}
		return (Bitmap)src.Clone();
	}

	public static List<string> ListZipFileNames(string zipFilePath)
	{
		List<string> result;
		try
		{
			List<string> list = new List<string>();
			using (ZipArchive zipArchive = ZipFile.OpenRead(zipFilePath))
			{
				foreach (ZipArchiveEntry entry in zipArchive.Entries)
				{
					list.Add(entry.FullName);
				}
			}
			result = list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void CheckDefaultOptions()
	{
		try
		{
			string value = Conversions.ToString(BTRegistry.GetValue(EXGuarder._21793B2A, Resources.Deafult_mob_optns));
			Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
			string deafult_mob_optns = Resources.Deafult_mob_optns;
			Dictionary<string, string> dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(deafult_mob_optns);
			bool flag = false;
			foreach (KeyValuePair<string, string> item in dictionary2)
			{
				if (!dictionary.ContainsKey(item.Key))
				{
					dictionary[item.Key] = item.Value;
					flag = true;
				}
			}
			if (flag)
			{
				string value2 = JsonConvert.SerializeObject(dictionary, Formatting.None);
				BTRegistry.AddOrUpdateValue(EXGuarder._21793B2A, value2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(EXGuarder._24225C52 + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static Bitmap connectionicon(string Str)
	{
		if (Operators.CompareString(Str, EXGuarder._5B1E6210, TextCompare: false) != 0)
		{
			if (Operators.CompareString(Str, EXGuarder._151D1D18, TextCompare: false) != 0)
			{
				if (Operators.CompareString(Str, EXGuarder._7356260C, TextCompare: false) != 0)
				{
					if (Operators.CompareString(Str, EXGuarder._10460769, TextCompare: false) != 0)
					{
						if (Operators.CompareString(Str, EXGuarder._5D794C57, TextCompare: false) != 0)
						{
							if (Operators.CompareString(Str, EXGuarder._3A530241, TextCompare: false) == 0)
							{
								return (Bitmap)Resources.disconect.Clone();
							}
							return (Bitmap)Resources.info_blue.Clone();
						}
						return (Bitmap)Resources.error_img.Clone();
					}
					return (Bitmap)Resources.info_blue.Clone();
				}
				return (Bitmap)Resources.block_con.Clone();
			}
			return (Bitmap)Resources.no_con.Clone();
		}
		return (Bitmap)Resources.ok_con.Clone();
	}

	public static string CleanFolderPath(string Tpath)
	{
		if (string.IsNullOrWhiteSpace(Tpath))
		{
			return Tpath;
		}
		bool flag = Tpath.StartsWith(EXGuarder._2C2A1848);
		bool flag2 = Tpath.EndsWith(EXGuarder._2C2A1848);
		string[] array = Tpath.Split('\\');
		List<string> list = new List<string>();
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				string text2 = text;
				char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
				foreach (char c in invalidFileNameChars)
				{
					text2 = text2.Replace(Conversions.ToString(c), EXGuarder._3B4C5C60);
				}
				text2 = text2.TrimEnd('.', ' ');
				text2 = Regex.Replace(text2, EXGuarder._13310A02, EXGuarder._0F465F02);
				if (text2.Length > 0)
				{
					list.Add(text2);
				}
			}
		}
		string text3 = string.Join(EXGuarder._2C2A1848, list);
		if (flag)
		{
			text3 = EXGuarder._2C2A1848 + text3;
		}
		if (flag2)
		{
			text3 += EXGuarder._2C2A1848;
		}
		return text3;
	}

	public static string CleanFileName(string name)
	{
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		char[] array = invalidFileNameChars;
		foreach (char c in array)
		{
			name = name.Replace(Conversions.ToString(c), EXGuarder._632E354F);
		}
		string[] source = new string[22]
		{
			EXGuarder._38526A6F,
			EXGuarder._664C4544,
			EXGuarder._0C402605,
			EXGuarder._700D2623,
			EXGuarder._02245064,
			EXGuarder._063E4528,
			EXGuarder._5D124401,
			EXGuarder._7102180D,
			EXGuarder._1E344952,
			EXGuarder._611F3E57,
			EXGuarder._21536E23,
			EXGuarder._236E132E,
			EXGuarder._4474130F,
			EXGuarder._45214A57,
			EXGuarder._5E19041F,
			EXGuarder._5663090C,
			EXGuarder._01583B17,
			EXGuarder._58433609,
			EXGuarder._2B061136,
			EXGuarder._4E6F6F70,
			EXGuarder._0035365E,
			EXGuarder._346D734B
		};
		name = Regex.Replace(name.Trim(), EXGuarder._616F5847, EXGuarder._78006872);
		name = name.TrimEnd('.', ' ');
		if (name.Length > 100)
		{
			name = name.Substring(0, 100);
		}
		if (source.Contains(name.ToUpperInvariant()))
		{
			name += EXGuarder._165F7123;
		}
		return name;
	}

	public static string loadjectors(string path)
	{
		if (!Directory.Exists(path))
		{
			return EXGuarder._77176349;
		}
		string[] files = Directory.GetFiles(path, EXGuarder._232F4F02);
		List<string> list = new List<string>();
		string[] array = files;
		foreach (string path2 in array)
		{
			list.Add(Path.GetFileNameWithoutExtension(path2));
		}
		if (list.Count == 0)
		{
			return EXGuarder._77176349;
		}
		return string.Join(EXGuarder._514F4361, list);
	}

	public static string BitmapToBase64(Bitmap bitmap)
	{
		using MemoryStream memoryStream = new MemoryStream();
		bitmap.Save(memoryStream, ImageFormat.Png);
		byte[] inArray = memoryStream.ToArray();
		return Convert.ToBase64String(inArray);
	}

	public static string ExtractHtmlFromZip(string zipFilePath)
	{
		using (ZipArchive zipArchive = ZipFile.OpenRead(zipFilePath))
		{
			foreach (ZipArchiveEntry entry in zipArchive.Entries)
			{
				if (!entry.FullName.EndsWith(EXGuarder._31605865, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				using Stream stream = entry.Open();
				using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
				return streamReader.ReadToEnd();
			}
		}
		return null;
	}

	public static void SetDoubleBuffered(Control control)
	{
		Type type = control.GetType();
		PropertyInfo property = type.GetProperty(EXGuarder._05495535, BindingFlags.Instance | BindingFlags.NonPublic);
		property.SetValue(control, true, null);
	}

	public static void ZipJectFile(string sourceFilePath, string destinationZipPath, string zippedFileName)
	{
		if (!File.Exists(sourceFilePath))
		{
			throw new FileNotFoundException(EXGuarder._171B5D78, sourceFilePath);
		}
		if (File.Exists(destinationZipPath))
		{
			File.Delete(destinationZipPath);
		}
		using FileStream stream = new FileStream(destinationZipPath, FileMode.Create);
		using ZipArchive destination = new ZipArchive(stream, ZipArchiveMode.Create);
		string entryName = (string.IsNullOrEmpty(zippedFileName) ? Path.GetFileName(sourceFilePath) : zippedFileName);
		destination.CreateEntryFromFile(sourceFilePath, entryName, CompressionLevel.Fastest);
	}

	public static string Createtemp(string content)
	{
		string tempFileName = Path.GetTempFileName();
		File.WriteAllText(tempFileName, content);
		return tempFileName;
	}

	public static string HtmlToBase64(string html)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(html);
		return Convert.ToBase64String(bytes);
	}

	public static string locallanguage()
	{
		string text = BTRegistry.GetValue(EXGuarder._3F3E104B, EXGuarder._351E620D).ToString().ToUpper();
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text))
		{
		case 1020607162u:
			if (Operators.CompareString(text, EXGuarder._2F015F0B, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._1A343244;
		case 2161779444u:
			if (Operators.CompareString(text, EXGuarder._5245366F, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0215;
		case 622328543u:
			if (Operators.CompareString(text, EXGuarder._7517414B, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0215;
		case 1745149088u:
			if (Operators.CompareString(text, EXGuarder._62602E3D, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._1D1A1542;
		case 653618115u:
			if (Operators.CompareString(text, EXGuarder._68533955, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._0C000823;
		case 1728224374u:
			if (Operators.CompareString(text, EXGuarder._17772613, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0242;
		case 634133545u:
			if (Operators.CompareString(text, EXGuarder._3006764A, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0242;
		case 1056972519u:
			if (Operators.CompareString(text, EXGuarder._74153D15, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0251;
		case 1023417281u:
			{
				if (Operators.CompareString(text, EXGuarder._15491844, TextCompare: false) != 0)
				{
					break;
				}
				goto IL_0251;
			}
			IL_0251:
			return EXGuarder._1C417140;
			IL_0242:
			return EXGuarder._46205C5F;
			IL_0215:
			return EXGuarder._4F5D522A;
		}
		return EXGuarder._351E620D;
	}

	public static string SafeGetValue(string[] arr, int index)
	{
		if (arr == null || index < 0 || index >= arr.Length || string.IsNullOrEmpty(arr[index]))
		{
			return EXGuarder._2C520169;
		}
		return arr[index];
	}

	public static void SaveSMSData(string[] SMSdata, string outputFile)
	{
		string _436C5A = EXGuarder._436C5A60;
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(EXGuarder._2F334253);
			stringBuilder.AppendLine(EXGuarder._2A21030D);
			foreach (string text in SMSdata)
			{
				try
				{
					string[] array = text.ToString().Split(new string[1] { _436C5A }, StringSplitOptions.None);
					if (array.Length > 1)
					{
						stringBuilder.AppendLine(EXGuarder._1008755F);
						int num = 0;
						do
						{
							stringBuilder.AppendLine(EXGuarder._1A546A5D + WebUtility.HtmlEncode(SafeGetValue(array, num)) + EXGuarder._204D6253);
							num = checked(num + 1);
						}
						while (num <= 6);
						stringBuilder.AppendLine(EXGuarder._0E115202);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Debuger.Log_e(EXGuarder._4D305446, EXtoString(ex2));
					ProjectData.ClearProjectError();
				}
			}
			stringBuilder.AppendLine(EXGuarder._5D285346);
			File.WriteAllText(outputFile, stringBuilder.ToString(), Encoding.UTF8);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Debuger.Log_e(EXGuarder._6A063F51, EXtoString(ex4));
			ProjectData.ClearProjectError();
		}
	}

	private static (int Major, int Minor, int Patch) ParseVersion(string versionString)
	{
		versionString = versionString.Trim().TrimStart('v', 'V');
		string[] array = versionString.Split('.');
		int item = ((array.Length > 0 && int.TryParse(array[0], out item)) ? item : 0);
		int item2 = ((array.Length > 1 && int.TryParse(array[1], out item2)) ? item2 : 0);
		int item3 = ((array.Length > 2 && int.TryParse(array[2], out item3)) ? item3 : 0);
		return (Major: item, Minor: item2, Patch: item3);
	}

	public static bool IsVersionGreater(string versionString, string compareTo)
	{
		(int, int, int) tuple = ParseVersion(versionString);
		(int, int, int) tuple2 = ParseVersion(compareTo);
		if (tuple.Item1 != tuple2.Item1)
		{
			return tuple.Item1 > tuple2.Item1;
		}
		if (tuple.Item2 != tuple2.Item2)
		{
			return tuple.Item2 > tuple2.Item2;
		}
		return tuple.Item3 > tuple2.Item3;
	}

	public static void BackgroundGradient(ref object Control, Color Color1, Color Color2)
	{
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(Conversions.ToInteger(NewLateBinding.LateGet(Control, null, EXGuarder._0B1C4100, new object[0], null, null, null)), Conversions.ToInteger(NewLateBinding.LateGet(Control, null, EXGuarder._23123E35, new object[0], null, null, null))), new Point(Conversions.ToInteger(NewLateBinding.LateGet(Control, null, EXGuarder._0B1C4100, new object[0], null, null, null)), 0), Color1, Color2);
		Graphics graphics = (Graphics)NewLateBinding.LateGet(Control, null, EXGuarder._166C2B4A, new object[0], null, null, null);
		TextureBrush textureBrush = new TextureBrush((Image)NewLateBinding.LateGet(Control, null, EXGuarder._54564271, new object[0], null, null, null));
		Graphics instance = graphics;
		string _0374594D = EXGuarder._0374594D;
		object[] obj = new object[2] { linearGradientBrush, null };
		object instance2 = Control;
		obj[1] = NewLateBinding.LateGet(instance2, null, EXGuarder._72575161, new object[0], null, null, null);
		object[] array = obj;
		bool[] obj2 = new bool[2] { true, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, _0374594D, obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			linearGradientBrush = (LinearGradientBrush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(LinearGradientBrush));
		}
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(instance2, null, EXGuarder._72575161, new object[1] { array[1] }, null, null, OptimisticSet: true, RValueBase: false);
		}
		Graphics instance3 = graphics;
		string _0374594D2 = EXGuarder._0374594D;
		object[] obj3 = new object[2] { textureBrush, null };
		instance2 = Control;
		obj3[1] = NewLateBinding.LateGet(instance2, null, EXGuarder._72575161, new object[0], null, null, null);
		array = obj3;
		NewLateBinding.LateCall(instance3, null, _0374594D2, obj3, null, null, array2 = new bool[2] { true, true }, IgnoreReturn: true);
		if (array2[0])
		{
			textureBrush = (TextureBrush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(TextureBrush));
		}
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(instance2, null, EXGuarder._72575161, new object[1] { array[1] }, null, null, OptimisticSet: true, RValueBase: false);
		}
		graphics.Dispose();
		graphics = null;
		textureBrush.Dispose();
		textureBrush = null;
	}

	public static bool IsServerAvailable(string ipAddress)
	{
		bool result;
		try
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(ipAddress, 15000);
			result = pingReply.Status == IPStatus.Success;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool IsUrlAvailable(string url)
	{
		bool result;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = EXGuarder._3A045B19;
			httpWebRequest.Timeout = 10000;
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			result = httpWebResponse.StatusCode == HttpStatusCode.OK;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static ServersInfo getSinfoByip(List<ServersInfo> AllServers, string serverip)
	{
		return AllServers.FirstOrDefault([SpecialName] (ServersInfo s) => s.Address.Equals(serverip, StringComparison.OrdinalIgnoreCase));
	}

	public static Color ConvertToRbg(string HexColor)
	{
		HexColor = Strings.Replace(HexColor, EXGuarder._1A55663E, EXGuarder._104D0922);
		string value = Conversions.ToString(Conversion.Val(EXGuarder._7414714E + Strings.Mid(HexColor, 1, 2)));
		string value2 = Conversions.ToString(Conversion.Val(EXGuarder._7414714E + Strings.Mid(HexColor, 3, 2)));
		string value3 = Conversions.ToString(Conversion.Val(EXGuarder._7414714E + Strings.Mid(HexColor, 5, 2)));
		return Color.FromArgb(Conversions.ToInteger(value), Conversions.ToInteger(value2), Conversions.ToInteger(value3));
	}

	private static string ToJson(object obj)
	{
		return JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(obj));
	}

	public static Color GetPingColor(string pingMs)
	{
		if (!int.TryParse(pingMs, out var result))
		{
			return Color.Gray;
		}
		int num = result;
		if (num <= 50)
		{
			return Color.Green;
		}
		if (num <= 100)
		{
			return Color.Yellow;
		}
		if (num <= 200)
		{
			return Color.Orange;
		}
		if (num <= 500)
		{
			return Color.Red;
		}
		return Color.DarkRed;
	}

	private static string NormalizeArabicDigits(string s)
	{
		char[] array = new char[10] { '٠', '١', '٢', '٣', '٤', '٥', '٦', '٧', '٨', '٩' };
		char[] array2 = new char[10] { '۰', '۱', '۲', '۳', '۴', '۵', '۶', '۷', '۸', '۹' };
		int num = 0;
		checked
		{
			do
			{
				s = s.Replace(array[num], Strings.ChrW(48 + num));
				s = s.Replace(array2[num], Strings.ChrW(48 + num));
				num++;
			}
			while (num <= 9);
			return s;
		}
	}

	public static string DaysPassed(string dateString)
	{
		string result;
		try
		{
			string s = NormalizeArabicDigits(dateString);
			DateTime dateTime = DateTime.ParseExact(s, EXGuarder._5C0B1121, CultureInfo.InvariantCulture);
			int days = (DateTime.Today - dateTime).Days;
			result = string.Format(EXGuarder._161E3A21, days, BTConst.daysstr);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = dateString;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius, bool roundTopLeft = true, bool roundTopRight = true, bool roundBottomRight = true, bool roundBottomLeft = true)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		checked
		{
			int num = radius * 2;
			if (roundTopLeft)
			{
				Rectangle rect2 = new Rectangle(rect.X, rect.Y, num, num);
				graphicsPath.AddArc(rect2, 180f, 90f);
			}
			else
			{
				graphicsPath.StartFigure();
				graphicsPath.AddLine(rect.X, rect.Y, rect.X, rect.Y);
			}
			if (roundTopRight)
			{
				Rectangle rect3 = new Rectangle(rect.Right - num, rect.Y, num, num);
				graphicsPath.AddArc(rect3, 270f, 90f);
			}
			else
			{
				graphicsPath.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);
			}
			if (roundBottomRight)
			{
				Rectangle rect4 = new Rectangle(rect.Right - num, rect.Bottom - num, num, num);
				graphicsPath.AddArc(rect4, 0f, 90f);
			}
			else
			{
				graphicsPath.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);
			}
			if (roundBottomLeft)
			{
				Rectangle rect5 = new Rectangle(rect.X, rect.Bottom - num, num, num);
				graphicsPath.AddArc(rect5, 90f, 90f);
			}
			else
			{
				graphicsPath.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);
			}
			graphicsPath.CloseFigure();
			return graphicsPath;
		}
	}

	public static string CommandWithOutput(string FileName, string Arguments, int waitfor = 5000)
	{
		string text = string.Empty;
		try
		{
			using Process process = new Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Arguments = Arguments;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			text = process.StandardOutput.ReadToEnd().Trim() + process.StandardError.ReadToEnd().Trim();
			if (waitfor == 0)
			{
				process.WaitForExit();
			}
			else
			{
				process.WaitForExit(waitfor);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception value = ex;
			Debug.WriteLine(value);
			ProjectData.ClearProjectError();
		}
		Debug.WriteLine(text);
		return text;
	}

	public static object RegexMatcher(string text, string match)
	{
		Regex regex = new Regex(text);
		Match match2 = regex.Match(match);
		return match2.ToString();
	}

	public static string QuoteArg(string value)
	{
		return EXGuarder._643A1310 + value.Trim('"') + EXGuarder._643A1310;
	}

	public static long GetTotalCacheSize(string parentPath)
	{
		long num = 0L;
		if (!Directory.Exists(parentPath))
		{
			return 0L;
		}
		foreach (string item in Directory.EnumerateDirectories(parentPath))
		{
			string text = Path.Combine(item, EXGuarder._32714455);
			if (Directory.Exists(text))
			{
				num = checked(num + FastFolderSize(text));
			}
		}
		return num;
	}

	private static long FastFolderSize(string folder)
	{
		long num = 0L;
		try
		{
			foreach (string item in Directory.EnumerateFiles(folder, EXGuarder._4454173C, SearchOption.AllDirectories))
			{
				try
				{
					num = checked(num + new FileInfo(item).Length);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static void CleanAllCache(string parentPath)
	{
		if (!Directory.Exists(parentPath))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(parentPath);
		foreach (string path in directories)
		{
			string path2 = Path.Combine(path, EXGuarder._4C60562A);
			if (Directory.Exists(path2))
			{
				try
				{
					Directory.Delete(path2, recursive: true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public static bool IsImageFile(string filePath)
	{
		bool result;
		if (!File.Exists(filePath))
		{
			result = false;
		}
		else
		{
			try
			{
				using (Image.FromFile(filePath))
				{
				}
				result = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	public static string GetImageMimeType(string filePath)
	{
		string text = Path.GetExtension(filePath).ToLower();
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text))
		{
		case 1128223456u:
			if (Operators.CompareString(text, EXGuarder._556D546B, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._32370A57;
		case 1388056268u:
			if (Operators.CompareString(text, EXGuarder._5A537735, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_020a;
		case 4178554255u:
			if (Operators.CompareString(text, EXGuarder._17602767, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_020a;
		case 1384894805u:
			if (Operators.CompareString(text, EXGuarder._07301F3E, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._07491A3E;
		case 175576948u:
			if (Operators.CompareString(text, EXGuarder._4E2A0A4E, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._2568445A;
		case 4100894060u:
			if (Operators.CompareString(text, EXGuarder._4A657941, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0237;
		case 3560597182u:
			if (Operators.CompareString(text, EXGuarder._384C681F, TextCompare: false) != 0)
			{
				break;
			}
			goto IL_0237;
		case 1287188703u:
			if (Operators.CompareString(text, EXGuarder._382A3F28, TextCompare: false) != 0)
			{
				break;
			}
			return EXGuarder._464A6014;
		case 3481738549u:
			{
				if (Operators.CompareString(text, EXGuarder._246E2060, TextCompare: false) != 0)
				{
					break;
				}
				return EXGuarder._00092051;
			}
			IL_0237:
			return EXGuarder._48041342;
			IL_020a:
			return EXGuarder._456C4D43;
		}
		return EXGuarder._1F35515E;
	}

	public static void ApplyThemeToControls(Control control, Theme theme)
	{
		foreach (Control control2 in control.Controls)
		{
			if (control2 is Button)
			{
				control2.BackColor = theme.ButtonColor;
				control2.ForeColor = theme.ForegroundColor;
			}
			else if (control2 is Label)
			{
				control2.ForeColor = theme.ForegroundColor;
			}
			else if (control2 is TextBox)
			{
				control2.BackColor = theme.BackgroundColor;
				control2.ForeColor = theme.ForegroundColor;
			}
			else if (control2 is ComboBox)
			{
				control2.BackColor = theme.BackgroundColor;
				control2.ForeColor = theme.ForegroundColor;
			}
			if (control2.HasChildren)
			{
				ApplyThemeToControls(control2, theme);
			}
		}
	}

	public static string jsstepsmaker(string[] steps)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(EXGuarder._51141064);
		checked
		{
			int num = steps.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string arg = steps[i].Trim();
				string arg2 = string.Format(EXGuarder._745E3556, arg);
				string arg3 = string.Format(EXGuarder._29667017, arg2);
				if (i < steps.Length - 1)
				{
					stringBuilder.AppendLine(string.Format(EXGuarder._484A3516, arg3));
				}
				else
				{
					stringBuilder.AppendLine(string.Format(EXGuarder._4D5D5C46, arg3));
				}
			}
			stringBuilder.AppendLine(EXGuarder._0A15083F);
			return stringBuilder.ToString();
		}
	}

	public static string jsstepsshow(string[] steps)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(EXGuarder._541C622E);
		checked
		{
			int num = steps.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string arg = steps[i].Trim();
				string arg2 = string.Format(EXGuarder._4F34505A, arg);
				string arg3 = string.Format(EXGuarder._29720236, arg2);
				if (i < steps.Length - 1)
				{
					stringBuilder.AppendLine(string.Format(EXGuarder._1F4F4815, arg3));
				}
				else
				{
					stringBuilder.AppendLine(string.Format(EXGuarder._5E482905, arg3));
				}
			}
			stringBuilder.AppendLine(EXGuarder._6F393350);
			return stringBuilder.ToString();
		}
	}

	public static string Random_Word_2()
	{
		if (Rndomizid == null)
		{
			Rndomizid = new Random();
		}
		return randmid2[Rndomizid.Next(0, checked(randmid2.Length - 1))];
	}

	public static string Random_Word_3()
	{
		if (Rndomizid3 == null)
		{
			Rndomizid3 = new Random();
		}
		return randmid3[Rndomizid3.Next(0, checked(randmid3.Length - 1))];
	}

	public static string Random_Word_4()
	{
		if (Rndomizid == null)
		{
			Rndomizid = new Random();
		}
		return randmid4[Rndomizid.Next(0, checked(randmid4.Length - 1))];
	}

	public static string FileToBase64(string filePath)
	{
		if (!File.Exists(filePath))
		{
			throw new FileNotFoundException(EXGuarder._50051D28, filePath);
		}
		byte[] inArray = File.ReadAllBytes(filePath);
		return Convert.ToBase64String(inArray);
	}
}
