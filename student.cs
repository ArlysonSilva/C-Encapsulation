class Student{

    //attributes 
    //First way
    private string? _name;
    public string? Name{
        get{return _name;}
        set{_name = value;}
    }

    //Second way
    public double Media{get; set;}
}