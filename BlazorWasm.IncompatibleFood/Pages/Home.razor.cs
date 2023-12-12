using BlazorWasm.IncompatibleFood.Models;
using BlazorWasm.IncompatibleFood.Services;
using static MudBlazor.CategoryTypes;

namespace BlazorWasm.IncompatibleFood.Pages
{
    public partial class Home
    {
        private IncompatibleFoodListResponseModel? DataList { get; set; }
        private IncompatibleFoodCategoryResponseModel? CategoryList { get; set; }
        private string? _category;

        protected override void OnInitialized()
        {
            DataList = _service.GetDataByPagination();
            CategoryList = _service.GetCategoryList();
        }
        private void PageChanged(int pageNo)
        {
            DataList = _service.GetDataByPagination(pageNo, category: _category);
        }

    }
}
