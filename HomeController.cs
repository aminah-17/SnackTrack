@model SnackTrackMvc.Models.Snack

@{
    ViewData["Title"] = "Edit Snack";
}

<div class="row justify-content-center">
    <div class="col-md-8 col-lg-7">

        <div class="page-header mb-4">
            <h2 class="fw-bold mb-1">✏️ Edit Snack</h2>
            <p class="mb-0 opacity-75">Update the details for <strong>@Model.Name</strong></p>
        </div>

        <div class="card p-4">
            <form asp-action="Edit" method="post">
                @Html.AntiForgeryToken()

                <!-- Hidden field to preserve the snack's ID through the form -->
                <input type="hidden" asp-for="Id" />
                <input type="hidden" asp-for="DateAdded" />

                <div class="mb-3">
                    <label asp-for="Name" class="form-label fw-semibold"></label>
                    <input asp-for="Name" class="form-control" />
                    <span asp-validation-for="Name" class="text-danger small"></span>
                </div>

                <div class="row g-3 mb-3">
                    <div class="col-md-6">
                        <label asp-for="Category" class="form-label fw-semibold"></label>
                        <select asp-for="Category" class="form-select">
                            <option value="">-- Select category --</option>
                            <option value="Sweet">Sweet</option>
                            <option value="Savoury">Savoury</option>
                            <option value="Drink">Drink</option>
                            <option value="Meal">Meal</option>
                            <option value="Healthy">Healthy</option>
                            <option value="Other">Other</option>
                        </select>
                        <span asp-validation-for="Category" class="text-danger small"></span>
                    </div>
                    <div class="col-md-6">
                        <label asp-for="Price" class="form-label fw-semibold"></label>
                        <div class="input-group">
                            <span class="input-group-text">R</span>
                            <input asp-for="Price" class="form-control" />
                        </div>
                        <span asp-validation-for="Price" class="text-danger small"></span>
                    </div>
                </div>

                <div class="mb-3">
                    <label asp-for="Location" class="form-label fw-semibold"></label>
                    <input asp-for="Location" class="form-control" />
                    <span asp-validation-for="Location" class="text-danger small"></span>
                </div>

                <div class="mb-3">
                    <label asp-for="Rating" class="form-label fw-semibold"></label>
                    <select asp-for="Rating" class="form-select">
                        <option value="1">★☆☆☆☆ — Poor</option>
                        <option value="2">★★☆☆☆ — Fair</option>
                        <option value="3">★★★☆☆ — Good</option>
                        <option value="4">★★★★☆ — Great</option>
                        <option value="5">★★★★★ — Excellent</option>
                    </select>
                    <span asp-validation-for="Rating" class="text-danger small"></span>
                </div>

                <div class="mb-4">
                    <label asp-for="Description" class="form-label fw-semibold"></label>
                    <textarea asp-for="Description" class="form-control" rows="3"></textarea>
                    <span asp-validation-for="Description" class="text-danger small"></span>
                </div>

                <div class="d-flex gap-2">
                    <button type="submit" class="btn btn-primary flex-fill fw-bold">
                        <i class="fas fa-save me-2"></i>Save Changes
                    </button>
                    <a asp-action="Details" asp-route-id="@Model.Id"
                       class="btn btn-outline-secondary flex-fill">
                        <i class="fas fa-times me-2"></i>Cancel
                    </a>
                </div>
            </form>
        </div>

    </div>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
