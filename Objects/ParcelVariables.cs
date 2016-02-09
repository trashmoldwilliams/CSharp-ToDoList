namespace Parcels.Objects
{
  public class ParcelVariables
  {
    public int Width { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int CostToShip { get; set; }
  }
  public class Parcel
  {
    private int _width;
    private int _length;
    private int _height;
    private int _weight;

    public Parcel(int width = 0, int length = 0, int height = 0, int weight = 0)
    {
      _width = width;
      _length = length;
      _height = height;
      _weight = weight;
    }

    public void SetWidth(int width)
    {
      _width = width;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetLength(int length)
    {
      _length = length;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetHeight(int height)
    {
      _height = height;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetWeight(int weight)
    {
      _weight = weight;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public int Volume()
    {
      int width = GetWidth();
      int height = GetHeight();
      int length = GetLength();
      return width*height*length;
    }

    public int CostToShip()
    {
      int volume = Volume();
      int weight = GetWeight();
      return (volume/5)+(weight/3)+1;
    }

  }

}
