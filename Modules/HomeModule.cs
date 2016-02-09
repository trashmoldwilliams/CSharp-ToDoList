using Nancy;
using Parcels.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/shipping"] = _ => {
        Parcel myParcel = new Parcel(Request.Query["Width"],Request.Query["Height"],Request.Query["Length"],Request.Query["Weight"]);
        ParcelVariables parcelVariables = new ParcelVariables
        {
          Width = myParcel.GetWidth(),
          Height = myParcel.GetHeight(),
          Length = myParcel.GetLength(),
          Weight = myParcel.GetWeight(),
          Volume = myParcel.Volume(),
          CostToShip = myParcel.CostToShip()
        };
        return View["shipping.html", parcelVariables];
      };
    }
  }


}
