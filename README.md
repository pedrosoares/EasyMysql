# EasyMysql 
It's a simple library to manipulate Mysql into C#, you can create, update and delete tables, insert, update and delete queries.

## Exemple:
```
MyConnection mc = MyConnection.GetInstance ();
mc.OnError(onErro); // called when an error occurred
/*host*/   /*database*/   /* user */	/*password*/
mc.configure ("127.0.0.1", "test",        "root",         ""); 

Table t = new Table ("User");
t.addColumn (new Column("nome", TypeColumn.VARCHAR, 100));

mc.addTable (t);
mc.createTables ();

List<Value> v = new List<Value> ();
v.Add (new Value("nome", TypeColumn.VARCHAR, "Eloisa Soares"));

t.insert (v);

List<Result> rr = t.select ();

foreach (Result re in rr) { 
    foreach(Value l in re.getValues()){ 
        Console.WriteLine ("Coluna: `"+l.getColumn().name+"` value: `"+l.getValue().ToString()+"`");
    }
}