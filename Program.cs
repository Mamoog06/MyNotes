Book bog = new Book("Programming notes", new List<Chapter>(){
    new Chapter("Variabler", new List<Page>(){
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo),
    }),
    new Chapter("Conditioner", new List<Page>(){
        new Page(MyNotes.conditionalsPageOne),
    }),
});

bog.Start();

