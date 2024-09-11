using System;

namespace Play.Inventory.Service.Dtos
{
    // item in users bag
    public record GrantItemDto(Guid UserId, Guid CatalogItemId, int Quantity);
    public record InventoryItemDto(Guid CatalogItemId, string Name, string Description, int Quantity, DateTimeOffset AcquiredDate);
    // item from Catalog.Service
    public record CatalogItemDto(Guid Id, string Name, string Description);
}