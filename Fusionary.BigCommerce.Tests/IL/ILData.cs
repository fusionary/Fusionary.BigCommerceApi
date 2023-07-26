using System.Text.Json;

namespace Fusionary.BigCommerce.Tests;

public static class ILData
{
    public static CategoryInfo[] GetCategories()
    {
        var categoryJson = """
[
  {
    "name": "Childrens",
    "code": "DVDCAT1",
    "status": "A"
  },
  {
    "name": "Documentaries",
    "code": "DVDCAT2",
    "status": "A"
  },
  {
    "name": "Drama",
    "code": "DVDCAT3",
    "status": "A"
  },
  {
    "name": "Educational - Teaching",
    "code": "DVDCAT4",
    "status": "A"
  },
  {
    "name": "Inspirational",
    "code": "DVDCAT5",
    "status": "A"
  },
  {
    "name": "Monarch",
    "code": "CURR1",
    "status": "A"
  },
  {
    "name": "Switched-On Schoolhouse",
    "code": "CURR2",
    "status": "A"
  },
  {
    "name": "Horizons",
    "code": "CURR3",
    "status": "A"
  },
  {
    "name": "LIFEPAC",
    "code": "CURR4",
    "status": "A"
  },
  {
    "name": "Weaver",
    "code": "CURR5",
    "status": "A"
  },
  {
    "name": "PreK",
    "code": "GL1",
    "status": "A"
  },
  {
    "name": "K",
    "code": "GL2",
    "status": "A"
  },
  {
    "name": "1st",
    "code": "GL3",
    "status": "A"
  },
  {
    "name": "2nd",
    "code": "GL4",
    "status": "A"
  },
  {
    "name": "3rd",
    "code": "GL5",
    "status": "A"
  },
  {
    "name": "4th",
    "code": "GL6",
    "status": "A"
  },
  {
    "name": "5th",
    "code": "GL7",
    "status": "A"
  },
  {
    "name": "6th",
    "code": "GL8",
    "status": "A"
  },
  {
    "name": "7th",
    "code": "GL9",
    "status": "A"
  },
  {
    "name": "8th",
    "code": "GL10",
    "status": "A"
  },
  {
    "name": "9th",
    "code": "GL11",
    "status": "A"
  },
  {
    "name": "10th",
    "code": "GL12",
    "status": "A"
  },
  {
    "name": "11th",
    "code": "GL13",
    "status": "A"
  },
  {
    "name": "12th",
    "code": "GL14",
    "status": "A"
  },
  {
    "name": "Bible",
    "code": "SUBJ1",
    "status": "A"
  },
  {
    "name": "Single Subject Sets",
    "code": "PT1",
    "status": "A"
  },
  {
    "name": "Electives",
    "code": "SUBJ3",
    "status": "A"
  },
  {
    "name": "History and Geography",
    "code": "SUBJ4",
    "status": "A"
  },
  {
    "name": "Language Arts",
    "code": "SUBJ5",
    "status": "A"
  },
  {
    "name": "Math",
    "code": "SUBJ6",
    "status": "A"
  },
  {
    "name": "Music",
    "code": "SUBJ7",
    "status": "I"
  },
  {
    "name": "Science",
    "code": "SUBJ8",
    "status": "A"
  },
  {
    "name": "Other",
    "code": "SUBJ9",
    "status": "A"
  },
  {
    "name": "CD",
    "code": "MTCD",
    "status": "A"
  },
  {
    "name": "DVD",
    "code": "MTDVD",
    "status": "A"
  },
  {
    "name": "Resources",
    "code": "CURR6",
    "status": "A"
  },
  {
    "name": "Complete Grade Sets",
    "code": "PT2",
    "status": "A"
  },
  {
    "name": "Electives - Career Courses",
    "code": "SUBJ11",
    "status": "A"
  },
  {
    "name": "Electives - State History",
    "code": "SUBJ12",
    "status": "A"
  },
  {
    "name": "Workbooks",
    "code": "PT3",
    "status": "A"
  },
  {
    "name": "Teacher’s Guides",
    "code": "PT4",
    "status": "A"
  },
  {
    "name": "Placement Tests",
    "code": "PT5",
    "status": "A"
  },
  {
    "name": "Other",
    "code": "PT6",
    "status": "A"
  },
  {
    "name": "Monarch",
    "code": "CURR1",
    "status": "A"
  },
  {
    "name": "Switched-On Schoolhouse",
    "code": "CURR2",
    "status": "A"
  },
  {
    "name": "Horizons",
    "code": "CURR3",
    "status": "A"
  },
  {
    "name": "LIFEPAC",
    "code": "CURR4",
    "status": "A"
  },
  {
    "name": "Weaver",
    "code": "CURR5",
    "status": "A"
  },
  {
    "name": "Resources",
    "code": "CURR6",
    "status": "A"
  },
  {
    "name": "Elective",
    "code": "PT7",
    "status": "A"
  },
  {
    "name": "Supplemental",
    "code": "SUBJ10",
    "status": "I"
  }
]
""";

        return JsonSerializer.Deserialize<CategoryInfo[]>(categoryJson)!;
    }
}