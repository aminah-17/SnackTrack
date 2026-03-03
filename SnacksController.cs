@model SnackTrackMvc.Models.Snack

@{
    ViewData["Title"] = Model.Name;
}

<div class="row justify-content-center">
    <div class="col-md-8 col-lg-7">

        <div class="card overflow-hidden">
            <!-- Colourful header banner -->
            <div style="background: linear-gradient(135deg, #1a1a2e, #16213e); padding: 2rem; color: white;">
                <div class="d-flex justify-content-between align-items-start">
                    <div>
                        <span class="badge rounded-pill mb-2" style="background: #ff6b2b; font-size: 0.85rem;">
                            @Model.Category
                        </span>
                        <h2 class="fw-bold mb-1">@Model.Name</h2>
                        <p class="mb-0 opacity-75">
                            <i class="fas fa-calendar me-1"></i>
                            Added @Model.DateAdded.ToString("d MMMM yyyy")
                        </p>
                    </div>
                    <div class="text-end">
                        <div class="display-6 fw-bold text-warning">
                            R@Model.Price.ToString("F2")
                        </div>
                        <div class="text-warning fs-5">
                            @for (int i = 1; i <= 5; i++)
                            {
                                <span>@(i <= Model.Rating ? "★" : "☆")</span>
                            }
                        </div>
                    </div>
                </div>
            </div>

            <div class="card-body p-4">
                <div class="mb-3">
                    <h6 class="text-muted text-uppercase small fw-bold mb-1">
                        <i class="fas fa-map-marker-alt me-1"></i>Where to Find It
                    </h6>
                    <p class="fs-5 mb-0">@Model.Location</p>
                </div>

                @if (!string.IsNullOrEmpty(Model.Description))
                {
                    <div class="mb-3">
                        <h6 class="text-muted text-uppercase small fw-bold mb-1">
                            <i class="fas fa-info-circle me-1"></i>Description
                        </h6>
                        <p class="mb-0">@Model.Description</p>
                    </div>
                }

                <div class="mb-4">
                    <h6 class="text-muted text-uppercase small fw-bold mb-1">
                        <i class="fas fa-star me-1"></i>Rating
                    </h6>
                    <p class="mb-0">@Model.Rating / 5 — 
                        @(Model.Rating switch {
                            5 => "Excellent ★★★★★",
                            4 => "Great ★★★★☆",
                            3 => "Good ★★★☆☆",
                            2 => "Fair ★★☆☆☆",
                            _ => "Poor ★☆☆☆☆"
                        })
                    </p>
                </div>

                <div class="d-flex flex-wrap gap-2 border-top pt-3">
                    <a asp-action="Edit" asp-route-id="@Model.Id" class="btn btn-primary">
                        <i class="fas fa-edit me-2"></i>Edit
                    </a>
                    <a asp-action="Delete" asp-route-id="@Model.Id" class="btn btn-outline-danger">
                        <i class="fas fa-trash me-2"></i>Delete
                    </a>
                    <a asp-action="Index" class="btn btn-outline-secondary ms-auto">
                        <i class="fas fa-arrow-left me-2"></i>Back to List
                    </a>
                </div>
            </div>
        </div>

    </div>
</div>
