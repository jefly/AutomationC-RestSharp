public class ObjectModel {
    public String Id { get; set; }
    public string Name { get; set; }
    public ObjectModelData Data { get; set; }
}

public class ObjectModelData
{
    public int Year { get; set; }
    public float Price { get; set; }
    public string CPUModel { get; set; }
    public string HardDiskSize { get; set; }
}
