Book bog = new Book("Programming notes");

List<Page> pages = new List<Page>();
Page variablesPage1 = new Page(MyNotes.VariablesPageOne);
Page variablesPage2 = new Page(MyNotes.VariablesPageTwo);
Page page3 = new Page("side 3");

pages.Add(variablesPage1);
pages.Add(variablesPage2);

Chapter variableChapter = new Chapter("Variabler");
variableChapter.Pages = pages;
Chapter chap2 = new Chapter("kapitel 2", pages);

variablesPage1.Read();
chap2.Read();

List<Chapter> chapters = new List<Chapter>();
chapters.Add(variableChapter);
chapters.Add(chap2);




//pause
Console.ReadLine();