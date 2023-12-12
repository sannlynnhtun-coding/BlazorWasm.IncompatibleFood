namespace BlazorWasm.IncompatibleFood.Models
{
    public class IncompatibleFoodListResponseModel
    {
        public List<IncompatibleFoodModel>? Data { get; set; }
        public PaginationModel? PageSetting { get; set; }
    }
}
