using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio
{
	public static class Text
	{
		public static String AboutMe = new("I am an alum of Jacksonville State University who majored in Computer Science with a " +
			"concentration in Game Development. I am striving to become a video game developer " +
			"but I enjoy creating various types of software. Other hobbies of mine include outdoor " +
			"activities such as hiking, biking and canoeing as well as performing on the trombone " +
			"line of the collegiate marching band The Marching Southerners. Through the Southerners " +
			"I have had the pleasure of traveling to locations and experiencing the cultures of " +
			"places such as Honolulu, Hawaii for the 75th Anniversary of Pearl Harbor and Rome," +
			"Italy for the New Year's Day World Peace Parade at the Vatican.");

		public static List<String> CollegeAchievements = new()
		{
			"President's List for 4.0 GPA (Fall 2017, Fall 2018, Spring 2020)",
			"Dean's List for 3.5 to 3.9 GPA (Spring 2018 and Fall 2019)",
			"Marching Southerners, Marching Band (2016-2019)",
			"Math Club member",
			"Open Horizons member"
		};

		public static List<String> HighSchoolAchievements = new()
		{
			"Eagle Scout(December 2015)",
			"Eagle Project consisted of replacing a 30 year old fence at First United Methodist Church in Alabaster, AL.",
			"The fence was 200 feet in length, approximately $2000, and took a month and a half to complete.",
			"Multiple meetings were held with the church committee and presentations were made at the local Lowe's home improvement for project discounts.",
			"Served as Troop Webmaster for six months, Senior Patrol Leader of the troop for six months, and Patrol Leader for two and a half years.",
			"Inducted into Order of the Arrow Spring 2014.",
			"Section Leader, Marching Band(Fall 2015 - Spring 2016)",
			"Led a group of 17 trombone members senior year of high school.",
			"Invited to the Music for All National Concert Band Festival in Indianapolis.",
			"Honor Societies and Extracurriculars",
			"National Honor Society",
			"Mu Alpha Theta",
			"Spanish Honor Society",
			"Scholars Bowl Team Member",
		};
	}
}
