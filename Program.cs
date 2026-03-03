@model SnackTrackMvc.Models.Snack

@{
    ViewData["Title"] = "Delete Snack";
}

<div class="row justify-content-center">
    <div class="col-md-7 col-lg-6">

        <!-- Warning header -->
        <div class="text-center mb-4">
            <div class="fs-1 mb-2">⚠️</div>
            <h2 class="fw-bold text-danger">Delete Snack?</h2>
            <p class="text-muted">This action cannot be undone.</p>
        </div>

        <!-- Snack preview card -->
        <div class="card border-danger mb-4">
            <div class="card-header bg-danger text-white fw-bold">
                Snack to be removed
            </div>
            <div class="card-body">
                <h5 class="fw-bold mb-1">@Model.Name</h5>
                <div class="row g-2 text-muted small">
                    <div class="col-6">
                        <i class="fas fa-tag me-1"></i>@Model.Category
                    </div>
                    <div class="col-6">
                        <i class="fas fa-dollar-sign me-1"></i>R@Model.Price.ToString("F2")
                    </div>
                    <div class="col-12">
                        <i class="fas fa-map-marker-alt me-1"></i>@Model.Location
                    </div>
                    <div class="col-12">
                        <span class="text-warning">
                            @for (int i = 1; i <= 5; i++)
                            {
                                <span>@(i <= Model.Rating ? "★" : "☆")</span>
                            }
                        </span>
                        <span class="ms-1">(@Model.Rating/5)</span>
                    </div>
                </div>
            </div>
        </div>

        <!-- Confirmation form -->
        <form asp-action="Delete" method="post">
            @Html.AntiForgeryToken()
            <!-- Hidden Id so DeleteConfirmed knows which record to remove -->
            <input type="hidden" asp-for="Id" />

            <div class="d-flex gap-2">
                <button type="submit" class="btn btn-danger flex-fill fw-bold">
                    <i class="fas fa-trash me-2"></i>Yes, Delete
                </button>
                <a asp-action="Details" asp-route-id="@Model.Id"
                   class="btn btn-outline-secondary flex-fill">
                    <i class="fas fa-arrow-left me-2"></i>Cancel
                </a>
            </div>
        </form>

    </div>
</div>
