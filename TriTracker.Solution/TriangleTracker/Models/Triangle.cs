namespace TriangleTracker
{
  public class Triangle
  {
    private int _sideOne;
    private int _sideTwo;
    private int _sideThree;
    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      _sideOne = sideOne;
      _sideTwo = sideTwo;
      _sideThree = sideThree;
    }

    public int GetSideOne()
    {
      return _sideOne;
    }

    public void SetSideOne(int sideOne)
    {
      _sideOne = sideOne;
    }

    public int GetSideTwo()
    {
      return _sideTwo;
    }

    public int GetSideThree()
    {
      return _sideThree;
    }

    public bool CheckAllSidesEqual()
    {
      if (_sideOne == _sideTwo && _sideOne == _sideThree)
      {
        return true;
      }
      return false;
    }

    public bool CheckIsosceles()
    {
      if (_sideOne == _sideTwo && _sideOne != _sideThree ||
      _sideTwo == _sideThree && _sideTwo != _sideOne ||
      _sideThree == _sideOne && _sideThree != _sideTwo)
      {
        return true;
      }
      return false;
    }

    public bool CheckIfScalene()
    {
      if (_sideOne != _sideTwo && _sideOne != _sideThree)
      {
        return true;
      }
      return false;
    }

    public bool CheckIfTriangle()
    {
      if (_sideOne > (_sideTwo + _sideThree) || _sideTwo > (_sideOne + _sideThree) || _sideThree > (_sideOne + _sideTwo))
      {
        return false;
      }
      return true;
    }

  }
}