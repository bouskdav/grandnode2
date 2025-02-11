﻿using Grand.Domain.Orders;
using Grand.Infrastructure.Models;
using Grand.Web.Models.Media;

namespace Grand.Web.Models.ShoppingCart
{
    public class AddToCartModel : BaseModel
    {
        public AddToCartModel()
        {
            Picture = new PictureModel();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSeName { get; set; }
        public string AttributeDescription { get; set; }
        public string ReservationInfo { get; set; }
        public PictureModel Picture { get; set; }
        public int Quantity { get; set; }
        public int ItemQuantity { get; set; }
        public string Price { get; set; }
        public double DecimalPrice { get; set; }
        public string TotalPrice { get; set; }
        public ShoppingCartType CartType { get; set; }

        public int TotalItems { get; set; }
        public string SubTotal { get; set; }
        public bool SubTotalIncludingTax { get; set; }
        public string SubTotalDiscount { get; set; }
        public double DecimalSubTotal { get; set; }

        public bool IsAuction { get; set; }
        public string HighestBid { get; set; }
        public double HighestBidValue { get; set; }
        public DateTime? EndTime { get; set; }
    }
}