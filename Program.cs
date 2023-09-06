﻿Book bog = new Book("Programming notes", new List<Chapter>(){
    new Chapter("Variabler", new List<Page>(){
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo),
    }),
    new Chapter("Conditioner", new List<Page>(){
        new Page(MyNotes.conditionalsPageOne),
        new Page(MyNotes.conditionalsPageTwo),
    }),
    new Chapter("Arrays", new List<Page>(){
        new Page(MyNotes.arraysPageOne),
    }),
});

bog.Start();

