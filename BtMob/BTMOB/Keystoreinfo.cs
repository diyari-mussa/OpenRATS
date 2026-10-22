using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

public class Keystoreinfo
{
	public class CountryProfile
	{
		public string Code;

		public string[] FirstNames;

		public string[] LastNames;

		public string[] Cities;

		public string[] States;

		public string[] OrgWords;
	}

	private static readonly Random rnd = new Random();

	private static readonly CountryProfile[] profiles = new CountryProfile[19]
	{
		new CountryProfile
		{
			Code = EXGuarder._552A4567,
			FirstNames = new string[10]
			{
				EXGuarder._024A1D38,
				EXGuarder._674E0A2B,
				EXGuarder._040A2B09,
				EXGuarder._37280B34,
				EXGuarder._00410D46,
				EXGuarder._23546D70,
				EXGuarder._4627780E,
				EXGuarder._3A596B21,
				EXGuarder._56752210,
				EXGuarder._06066D6F
			},
			LastNames = new string[7]
			{
				EXGuarder._2261702B,
				EXGuarder._77215C16,
				EXGuarder._533E6362,
				EXGuarder._22050870,
				EXGuarder._0B39464E,
				EXGuarder._1F621871,
				EXGuarder._261E5569
			},
			Cities = new string[6]
			{
				EXGuarder._57740552,
				EXGuarder._403B6A57,
				EXGuarder._701F222F,
				EXGuarder._37210572,
				EXGuarder._5F716606,
				EXGuarder._314F1507
			},
			States = new string[5]
			{
				EXGuarder._08424820,
				EXGuarder._6F39314D,
				EXGuarder._6F355019,
				EXGuarder._1E0B0154,
				EXGuarder._4B393D6C
			},
			OrgWords = new string[6]
			{
				EXGuarder._1E00650D,
				EXGuarder._10766B6C,
				EXGuarder._781B3077,
				EXGuarder._151F5E4E,
				EXGuarder._1367514B,
				EXGuarder._502A7314
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._5827290F,
			FirstNames = new string[10]
			{
				EXGuarder._1A323575,
				EXGuarder._77696870,
				EXGuarder._326C680F,
				EXGuarder._48042F6B,
				EXGuarder._23546D70,
				EXGuarder._3F4D2113,
				EXGuarder._50356C2D,
				EXGuarder._2B770955,
				EXGuarder._1578731B,
				EXGuarder._143A3B5A
			},
			LastNames = new string[7]
			{
				EXGuarder._00212D75,
				EXGuarder._3B2E4525,
				EXGuarder._68492058,
				EXGuarder._610A3143,
				EXGuarder._23125524,
				EXGuarder._25775A75,
				EXGuarder._71662932
			},
			Cities = new string[7]
			{
				EXGuarder._35380A3C,
				EXGuarder._352C154D,
				EXGuarder._6E1E6207,
				EXGuarder._3D724604,
				EXGuarder._68394821,
				EXGuarder._5E733C6F,
				EXGuarder._56207132
			},
			States = new string[6]
			{
				EXGuarder._13786E2B,
				EXGuarder._25283B64,
				EXGuarder._23261541,
				EXGuarder._35380A3C,
				EXGuarder._762C6005,
				EXGuarder._05410535
			},
			OrgWords = new string[7]
			{
				EXGuarder._0B11662C,
				EXGuarder._1367514B,
				EXGuarder._1B2F563E,
				EXGuarder._10766B6C,
				EXGuarder._1627515B,
				EXGuarder._673D3D04,
				EXGuarder._150E7323
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._310A2A32,
			FirstNames = new string[9]
			{
				EXGuarder._263F5A28,
				EXGuarder._604A1844,
				EXGuarder._1D576829,
				EXGuarder._06032165,
				EXGuarder._5A0F551C,
				EXGuarder._05601640,
				EXGuarder._2665201A,
				EXGuarder._0F3D1557,
				EXGuarder._30270D38
			},
			LastNames = new string[7]
			{
				EXGuarder._634D183D,
				EXGuarder._36590501,
				EXGuarder._67185633,
				EXGuarder._0D765A6B,
				EXGuarder._19100C02,
				EXGuarder._57036739,
				EXGuarder._6F3B1E0A
			},
			Cities = new string[6]
			{
				EXGuarder._730C1653,
				EXGuarder._32131477,
				EXGuarder._1C72552C,
				EXGuarder._14606C32,
				EXGuarder._3430676A,
				EXGuarder._3E3C4A5E
			},
			States = new string[5]
			{
				EXGuarder._730C1653,
				EXGuarder._32131477,
				EXGuarder._4934522B,
				EXGuarder._1C72552C,
				EXGuarder._2D631047
			},
			OrgWords = new string[6]
			{
				EXGuarder._1E00650D,
				EXGuarder._41116A0A,
				EXGuarder._1367514B,
				EXGuarder._10766B6C,
				EXGuarder._1627515B,
				EXGuarder._44446810
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._17165C6D,
			FirstNames = new string[10]
			{
				EXGuarder._5411613B,
				EXGuarder._322A570A,
				EXGuarder._6B1C2B16,
				EXGuarder._3E387948,
				EXGuarder._16351F1D,
				EXGuarder._666E6722,
				EXGuarder._76112A1E,
				EXGuarder._1C361863,
				EXGuarder._66040900,
				EXGuarder._622B6651
			},
			LastNames = new string[7]
			{
				EXGuarder._1D62296B,
				EXGuarder._525D6679,
				EXGuarder._79600B63,
				EXGuarder._63184F16,
				EXGuarder._05105011,
				EXGuarder._05021B75,
				EXGuarder._3E0B5967
			},
			Cities = new string[6]
			{
				EXGuarder._72635910,
				EXGuarder._3628583F,
				EXGuarder._29123015,
				EXGuarder._0B6E6D65,
				EXGuarder._0E353C3B,
				EXGuarder._48067745
			},
			States = new string[5]
			{
				EXGuarder._72635910,
				EXGuarder._3628583F,
				EXGuarder._29123015,
				EXGuarder._0E353C3B,
				EXGuarder._0B3A0B36
			},
			OrgWords = new string[6]
			{
				EXGuarder._1A601C77,
				EXGuarder._224E752F,
				EXGuarder._1E00650D,
				EXGuarder._494F2474,
				EXGuarder._10766B6C,
				EXGuarder._211E3216
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._2B0E472E,
			FirstNames = new string[9]
			{
				EXGuarder._615C7933,
				EXGuarder._1A44030F,
				EXGuarder._0350225C,
				EXGuarder._633B1A66,
				EXGuarder._03412733,
				EXGuarder._0F6F0473,
				EXGuarder._6366766D,
				EXGuarder._23546D70,
				EXGuarder._63355A6F
			},
			LastNames = new string[7]
			{
				EXGuarder._0223450C,
				EXGuarder._77460B54,
				EXGuarder._2E405C59,
				EXGuarder._45042041,
				EXGuarder._32235C20,
				EXGuarder._3F696C2B,
				EXGuarder._26656B51
			},
			Cities = new string[6]
			{
				EXGuarder._6B17424C,
				EXGuarder._2D270C1F,
				EXGuarder._3E611B35,
				EXGuarder._4D081B6B,
				EXGuarder._28104D36,
				EXGuarder._245D294B
			},
			States = new string[5]
			{
				EXGuarder._5D582018,
				EXGuarder._6B17424C,
				EXGuarder._11411850,
				EXGuarder._26500456,
				EXGuarder._3100083C
			},
			OrgWords = new string[6]
			{
				EXGuarder._10766B6C,
				EXGuarder._5C234A70,
				EXGuarder._1E00650D,
				EXGuarder._151F5E4E,
				EXGuarder._1627515B,
				EXGuarder._42466E1A
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._60035A14,
			FirstNames = new string[9]
			{
				EXGuarder._1F483E07,
				EXGuarder._4D19143A,
				EXGuarder._3F420974,
				EXGuarder._4C677624,
				EXGuarder._65416D22,
				EXGuarder._31434360,
				EXGuarder._7974641C,
				EXGuarder._3C74375D,
				EXGuarder._5E696D69
			},
			LastNames = new string[7]
			{
				EXGuarder._5E0A6F3B,
				EXGuarder._1B112D3F,
				EXGuarder._352C7207,
				EXGuarder._5274641B,
				EXGuarder._702A3231,
				EXGuarder._54287478,
				EXGuarder._53543C31
			},
			Cities = new string[5]
			{
				EXGuarder._09476C75,
				EXGuarder._26025E01,
				EXGuarder._76374562,
				EXGuarder._48504B43,
				EXGuarder._49474047
			},
			States = new string[4]
			{
				EXGuarder._642D5025,
				EXGuarder._26025E01,
				EXGuarder._40041309,
				EXGuarder._4A2E511C
			},
			OrgWords = new string[6]
			{
				EXGuarder._44110D24,
				EXGuarder._14144F74,
				EXGuarder._7972626B,
				EXGuarder._10766B6C,
				EXGuarder._2E171247,
				EXGuarder._6B70774C
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._2E513005,
			FirstNames = new string[10]
			{
				EXGuarder._06207978,
				EXGuarder._1713232E,
				EXGuarder._116C2833,
				EXGuarder._653A2014,
				EXGuarder._46484F30,
				EXGuarder._5A0B1765,
				EXGuarder._55154805,
				EXGuarder._00236F07,
				EXGuarder._304C4224,
				EXGuarder._41226D33
			},
			LastNames = new string[7]
			{
				EXGuarder._771E3560,
				EXGuarder._00236F07,
				EXGuarder._3E052D35,
				EXGuarder._41226D33,
				EXGuarder._5477443B,
				EXGuarder._250E4162,
				EXGuarder._02482169
			},
			Cities = new string[6]
			{
				EXGuarder._4B53651C,
				EXGuarder._025C774D,
				EXGuarder._4D704776,
				EXGuarder._3228630B,
				EXGuarder._322A1D46,
				EXGuarder._056C3565
			},
			States = new string[5]
			{
				EXGuarder._2D081764,
				EXGuarder._37433F1D,
				EXGuarder._5F6A0772,
				EXGuarder._4B53651C,
				EXGuarder._025C774D
			},
			OrgWords = new string[7]
			{
				EXGuarder._21403360,
				EXGuarder._3E216A1B,
				EXGuarder._3A032746,
				EXGuarder._1E00650D,
				EXGuarder._1367514B,
				EXGuarder._2D6E1741,
				EXGuarder._483B5229
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._0F44530F,
			FirstNames = new string[9]
			{
				EXGuarder._19321D13,
				EXGuarder._79330A6C,
				EXGuarder._27443A46,
				EXGuarder._7974641C,
				EXGuarder._48331B25,
				EXGuarder._3E15576D,
				EXGuarder._4C694374,
				EXGuarder._28233B72,
				EXGuarder._223F571F
			},
			LastNames = new string[7]
			{
				EXGuarder._2F2D675E,
				EXGuarder._64172B38,
				EXGuarder._09643E64,
				EXGuarder._555E0E26,
				EXGuarder._44163B5A,
				EXGuarder._52784D74,
				EXGuarder._5D680341
			},
			Cities = new string[6]
			{
				EXGuarder._25000350,
				EXGuarder._17523124,
				EXGuarder._32342073,
				EXGuarder._0B396265,
				EXGuarder._44401002,
				EXGuarder._00752B01
			},
			States = new string[5]
			{
				EXGuarder._6F271613,
				EXGuarder._093A1719,
				EXGuarder._25000350,
				EXGuarder._32342073,
				EXGuarder._2A250A5D
			},
			OrgWords = new string[6]
			{
				EXGuarder._433A054D,
				EXGuarder._1E00650D,
				EXGuarder._151F5E4E,
				EXGuarder._10766B6C,
				EXGuarder._1627515B,
				EXGuarder._275C0C2B
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._380C6C55,
			FirstNames = new string[10]
			{
				EXGuarder._273E014C,
				EXGuarder._08276D33,
				EXGuarder._4C260439,
				EXGuarder._51772835,
				EXGuarder._491F242A,
				EXGuarder._6E126C11,
				EXGuarder._2F37501E,
				EXGuarder._3D063B56,
				EXGuarder._2A121D1D,
				EXGuarder._1C430D4F
			},
			LastNames = new string[7]
			{
				EXGuarder._0F394624,
				EXGuarder._014E2757,
				EXGuarder._045F2023,
				EXGuarder._5C301A4F,
				EXGuarder._463B2F13,
				EXGuarder._1B36051E,
				EXGuarder._741A3823
			},
			Cities = new string[6]
			{
				EXGuarder._12740A6A,
				EXGuarder._1655381C,
				EXGuarder._3B1B2356,
				EXGuarder._58620550,
				EXGuarder._37014756,
				EXGuarder._1E0F5712
			},
			States = new string[5]
			{
				EXGuarder._12740A6A,
				EXGuarder._17686517,
				EXGuarder._460A434C,
				EXGuarder._58620550,
				EXGuarder._6D0D1718
			},
			OrgWords = new string[7]
			{
				EXGuarder._22466E4F,
				EXGuarder._0F1A2073,
				EXGuarder._164E3D6A,
				EXGuarder._5D2C0B75,
				EXGuarder._1E00650D,
				EXGuarder._1249311A,
				EXGuarder._793F1F6C
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._514B4B3E,
			FirstNames = new string[10]
			{
				EXGuarder._47295440,
				EXGuarder._08276D33,
				EXGuarder._7928184E,
				EXGuarder._79581B3E,
				EXGuarder._51772835,
				EXGuarder._1C361863,
				EXGuarder._0A4C2130,
				EXGuarder._54406C44,
				EXGuarder._4735204A,
				EXGuarder._756A526E
			},
			LastNames = new string[7]
			{
				EXGuarder._47295440,
				EXGuarder._08276D33,
				EXGuarder._66040900,
				EXGuarder._756A526E,
				EXGuarder._7928184E,
				EXGuarder._57263519,
				EXGuarder._6156523F
			},
			Cities = new string[6]
			{
				EXGuarder._491B0866,
				EXGuarder._5747503F,
				EXGuarder._61662725,
				EXGuarder._150D4134,
				EXGuarder._1348473F,
				EXGuarder._1B487550
			},
			States = new string[5]
			{
				EXGuarder._491B0866,
				EXGuarder._5747503F,
				EXGuarder._61662725,
				EXGuarder._5110646B,
				EXGuarder._6E5F6C24
			},
			OrgWords = new string[7]
			{
				EXGuarder._5C126E3D,
				EXGuarder._59251775,
				EXGuarder._0005343E,
				EXGuarder._1367514B,
				EXGuarder._151F5E4E,
				EXGuarder._4543180F,
				EXGuarder._4D040E49
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._6003492A,
			FirstNames = new string[9]
			{
				EXGuarder._273E014C,
				EXGuarder._08276D33,
				EXGuarder._491F242A,
				EXGuarder._4C260439,
				EXGuarder._2A121D1D,
				EXGuarder._23645C17,
				EXGuarder._0A4C2130,
				EXGuarder._69393704,
				EXGuarder._1903205F
			},
			LastNames = new string[6]
			{
				EXGuarder._1177095E,
				EXGuarder._3C343E60,
				EXGuarder._08276D33,
				EXGuarder._44687326,
				EXGuarder._756A526E,
				EXGuarder._741A3823
			},
			Cities = new string[5]
			{
				EXGuarder._1C731F78,
				EXGuarder._22682932,
				EXGuarder._20740E65,
				EXGuarder._72374B6A,
				EXGuarder._17307172
			},
			States = new string[4]
			{
				EXGuarder._1C731F78,
				EXGuarder._22682932,
				EXGuarder._20740E65,
				EXGuarder._755F0A61
			},
			OrgWords = new string[7]
			{
				EXGuarder._5C6D333D,
				EXGuarder._164E3D6A,
				EXGuarder._1249311A,
				EXGuarder._58307534,
				EXGuarder._0B11662C,
				EXGuarder._58100959,
				EXGuarder._1367514B
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._39797939,
			FirstNames = new string[9]
			{
				EXGuarder._47295440,
				EXGuarder._08276D33,
				EXGuarder._4735204A,
				EXGuarder._3C622E00,
				EXGuarder._2A121D1D,
				EXGuarder._29320F46,
				EXGuarder._7413406D,
				EXGuarder._756A526E,
				EXGuarder._51772835
			},
			LastNames = new string[6]
			{
				EXGuarder._0D456176,
				EXGuarder._372C0969,
				EXGuarder._23096E2D,
				EXGuarder._6134456B,
				EXGuarder._2C250A10,
				EXGuarder._5A650609
			},
			Cities = new string[6]
			{
				EXGuarder._754E5212,
				EXGuarder._33353949,
				EXGuarder._5D26062C,
				EXGuarder._4C312474,
				EXGuarder._02580440,
				EXGuarder._0D69692F
			},
			States = new string[4]
			{
				EXGuarder._15241D5F,
				EXGuarder._3775741F,
				EXGuarder._40593334,
				EXGuarder._584E6A17
			},
			OrgWords = new string[6]
			{
				EXGuarder._1C725E1E,
				EXGuarder._40765233,
				EXGuarder._1E00650D,
				EXGuarder._5D26062C,
				EXGuarder._151F5E4E,
				EXGuarder._415D5412
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._50421A4D,
			FirstNames = new string[8]
			{
				EXGuarder._30772B44,
				EXGuarder._08276D33,
				EXGuarder._51772835,
				EXGuarder._66040900,
				EXGuarder._4A4B266D,
				EXGuarder._0478050B,
				EXGuarder._2F37501E,
				EXGuarder._3E13331F
			},
			LastNames = new string[6]
			{
				EXGuarder._5D774824,
				EXGuarder._5B19555B,
				EXGuarder._6B340261,
				EXGuarder._6C5A6C55,
				EXGuarder._260C376A,
				EXGuarder._6156523F
			},
			Cities = new string[5]
			{
				EXGuarder._484F295A,
				EXGuarder._24000530,
				EXGuarder._115C6B03,
				EXGuarder._5F5A4A2E,
				EXGuarder._4566283F
			},
			States = new string[4]
			{
				EXGuarder._484F295A,
				EXGuarder._24000530,
				EXGuarder._115C6B03,
				EXGuarder._79006F2B
			},
			OrgWords = new string[6]
			{
				EXGuarder._7839553C,
				EXGuarder._4566283F,
				EXGuarder._1E00650D,
				EXGuarder._1367514B,
				EXGuarder._151F5E4E,
				EXGuarder._414E4B03
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._19720826,
			FirstNames = new string[10]
			{
				EXGuarder._0A0E3211,
				EXGuarder._5E0A4229,
				EXGuarder._37280B34,
				EXGuarder._4A566404,
				EXGuarder._69072C20,
				EXGuarder._5B59241A,
				EXGuarder._7974641C,
				EXGuarder._50002B5B,
				EXGuarder._71482358,
				EXGuarder._78033E01
			},
			LastNames = new string[7]
			{
				EXGuarder._696C3A71,
				EXGuarder._0D4E1365,
				EXGuarder._25362D53,
				EXGuarder._06722511,
				EXGuarder._08434373,
				EXGuarder._07237141,
				EXGuarder._3B252222
			},
			Cities = new string[6]
			{
				EXGuarder._2F003316,
				EXGuarder._6D287131,
				EXGuarder._62362C1D,
				EXGuarder._4E191A1D,
				EXGuarder._155B243F,
				EXGuarder._57786472
			},
			States = new string[6]
			{
				EXGuarder._2F003316,
				EXGuarder._6D287131,
				EXGuarder._6A220E50,
				EXGuarder._1F51181C,
				EXGuarder._3E77083C,
				EXGuarder._5C2C3970
			},
			OrgWords = new string[7]
			{
				EXGuarder._550A5668,
				EXGuarder._09440160,
				EXGuarder._1E00650D,
				EXGuarder._151F5E4E,
				EXGuarder._1367514B,
				EXGuarder._5534063B,
				EXGuarder._75082F63
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._1B5C0B33,
			FirstNames = new string[9]
			{
				EXGuarder._410A4441,
				EXGuarder._35440A6A,
				EXGuarder._47292A18,
				EXGuarder._75732E62,
				EXGuarder._186D2F02,
				EXGuarder._296C3163,
				EXGuarder._3D3E0E53,
				EXGuarder._2A0D3F6E,
				EXGuarder._4F400860
			},
			LastNames = new string[7]
			{
				EXGuarder._04065110,
				EXGuarder._571D1F44,
				EXGuarder._26781F61,
				EXGuarder._50373E26,
				EXGuarder._00670E31,
				EXGuarder._4C221D28,
				EXGuarder._1E4F0A73
			},
			Cities = new string[6]
			{
				EXGuarder._695C5716,
				EXGuarder._57514434,
				EXGuarder._3A790275,
				EXGuarder._75692951,
				EXGuarder._6033510E,
				EXGuarder._72780263
			},
			States = new string[5]
			{
				EXGuarder._09715136,
				EXGuarder._57514434,
				EXGuarder._2C250B54,
				EXGuarder._30764A55,
				EXGuarder._2568192F
			},
			OrgWords = new string[7]
			{
				EXGuarder._1367514B,
				EXGuarder._0B11662C,
				EXGuarder._1E00650D,
				EXGuarder._1B4B2052,
				EXGuarder._47605A68,
				EXGuarder._70265B69,
				EXGuarder._143A5042
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._47695E11,
			FirstNames = new string[8]
			{
				EXGuarder._28090A04,
				EXGuarder._104A3C09,
				EXGuarder._50387953,
				EXGuarder._27536828,
				EXGuarder._421C7000,
				EXGuarder._48331B25,
				EXGuarder._4E096636,
				EXGuarder._6E326274
			},
			LastNames = new string[6]
			{
				EXGuarder._58746055,
				EXGuarder._6E270B52,
				EXGuarder._01222F20,
				EXGuarder._55156C5A,
				EXGuarder._100E1F5C,
				EXGuarder._46285866
			},
			Cities = new string[6]
			{
				EXGuarder._153C7065,
				EXGuarder._1D513D10,
				EXGuarder._2E613F37,
				EXGuarder._02155167,
				EXGuarder._04285673,
				EXGuarder._14251949
			},
			States = new string[5]
			{
				EXGuarder._20631E56,
				EXGuarder._603A1D79,
				EXGuarder._351F0E42,
				EXGuarder._1C32214B,
				EXGuarder._1930222A
			},
			OrgWords = new string[6]
			{
				EXGuarder._5E680065,
				EXGuarder._1E00650D,
				EXGuarder._7952782F,
				EXGuarder._151F5E4E,
				EXGuarder._29750167,
				EXGuarder._1367514B
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._04327305,
			FirstNames = new string[8]
			{
				EXGuarder._146F6459,
				EXGuarder._1D5C7457,
				EXGuarder._70437509,
				EXGuarder._0B0A5C46,
				EXGuarder._3F4D2113,
				EXGuarder._11704824,
				EXGuarder._695E0E71,
				EXGuarder._50356C2D
			},
			LastNames = new string[7]
			{
				EXGuarder._00212D75,
				EXGuarder._2B28724F,
				EXGuarder._610A3143,
				EXGuarder._68492058,
				EXGuarder._1C083408,
				EXGuarder._25775A75,
				EXGuarder._3B2E4525
			},
			Cities = new string[6]
			{
				EXGuarder._0B30691B,
				EXGuarder._4B72214D,
				EXGuarder._1B5E0C2F,
				EXGuarder._5B47166C,
				EXGuarder._6828226E,
				EXGuarder._4E161250
			},
			States = new string[5]
			{
				EXGuarder._614C7468,
				EXGuarder._3D795A4C,
				EXGuarder._0C3D045F,
				EXGuarder._08347951,
				EXGuarder._78176677
			},
			OrgWords = new string[7]
			{
				EXGuarder._13394803,
				EXGuarder._0B11662C,
				EXGuarder._1367514B,
				EXGuarder._151F5E4E,
				EXGuarder._08441401,
				EXGuarder._0B30691B,
				EXGuarder._10766B6C
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._670E2E46,
			FirstNames = new string[8]
			{
				EXGuarder._4C694374,
				EXGuarder._64152B11,
				EXGuarder._110A2C1D,
				EXGuarder._223F571F,
				EXGuarder._48331B25,
				EXGuarder._534C5332,
				EXGuarder._27443A46,
				EXGuarder._5A3C562A
			},
			LastNames = new string[6]
			{
				EXGuarder._55720630,
				EXGuarder._09643E64,
				EXGuarder._64172B38,
				EXGuarder._2F2D675E,
				EXGuarder._14747165,
				EXGuarder._4F38762E
			},
			Cities = new string[5]
			{
				EXGuarder._5436132C,
				EXGuarder._656A5705,
				EXGuarder._57623004,
				EXGuarder._7531150E,
				EXGuarder._2915616E
			},
			States = new string[5]
			{
				EXGuarder._5436132C,
				EXGuarder._0D500638,
				EXGuarder._6B000129,
				EXGuarder._2B176A76,
				EXGuarder._2E656C5A
			},
			OrgWords = new string[6]
			{
				EXGuarder._59203344,
				EXGuarder._1E00650D,
				EXGuarder._5D145B76,
				EXGuarder._151F5E4E,
				EXGuarder._1367514B,
				EXGuarder._6C491E51
			}
		},
		new CountryProfile
		{
			Code = EXGuarder._664B012B,
			FirstNames = new string[8]
			{
				EXGuarder._0B0A5C46,
				EXGuarder._1578731B,
				EXGuarder._146F6459,
				EXGuarder._37280B34,
				EXGuarder._03412733,
				EXGuarder._3F4D2113,
				EXGuarder._05591D62,
				EXGuarder._143A3B5A
			},
			LastNames = new string[6]
			{
				EXGuarder._00212D75,
				EXGuarder._25775A75,
				EXGuarder._68492058,
				EXGuarder._610A3143,
				EXGuarder._2B28724F,
				EXGuarder._1C083408
			},
			Cities = new string[5]
			{
				EXGuarder._5C675A45,
				EXGuarder._4F524D06,
				EXGuarder._06796338,
				EXGuarder._620C4F26,
				EXGuarder._721D4431
			},
			States = new string[4]
			{
				EXGuarder._15387913,
				EXGuarder._6177071A,
				EXGuarder._164D032D,
				EXGuarder._066C3239
			},
			OrgWords = new string[6]
			{
				EXGuarder._0A57496F,
				EXGuarder._5C675A45,
				EXGuarder._1E00650D,
				EXGuarder._0B11662C,
				EXGuarder._5770300A,
				EXGuarder._1367514B
			}
		}
	};

	public static CountryProfile GenerateProfile()
	{
		return profiles[rnd.Next(profiles.Length)];
	}

	public static CountryProfile GenerateProfile(string countryCode)
	{
		CountryProfile[] array = profiles;
		foreach (CountryProfile countryProfile in array)
		{
			if (Operators.CompareString(countryProfile.Code.ToUpper(), countryCode.ToUpper(), TextCompare: false) == 0)
			{
				return countryProfile;
			}
		}
		return GenerateProfile();
	}

	public static string GenerateCN(CountryProfile profile)
	{
		return GetRandom(profile.FirstNames) + EXGuarder._25685E09 + GetRandom(profile.LastNames);
	}

	public static string GenerateOU(CountryProfile profile)
	{
		return GetRandom(profile.OrgWords) + EXGuarder._123D0951;
	}

	public static string GenerateO(CountryProfile profile)
	{
		return GetRandom(profile.OrgWords) + EXGuarder._25044B4F + GetRandom(profile.OrgWords);
	}

	public static string GenerateL(CountryProfile profile)
	{
		return GetRandom(profile.Cities);
	}

	public static string GenerateS(CountryProfile profile)
	{
		return GetRandom(profile.States);
	}

	public static string GenerateAliasName(string cn, string countryCode)
	{
		return codes.Random_Word_2();
	}

	public static string GeneratePassword(int length = 16)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= length; i = checked(i + 1))
		{
			stringBuilder.Append(EXGuarder._35305425[rnd.Next(EXGuarder._35305425.Length)]);
		}
		return stringBuilder.ToString();
	}

	private static string GetRandom(string[] items)
	{
		return items[rnd.Next(items.Length)];
	}
}
