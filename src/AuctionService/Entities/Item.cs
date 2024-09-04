using AuctionService.Entities;

namespace AuctionService;
    public class Item
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Color { get; set; }

        public int Mileage { get; set; }

        public int ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
// nav properties

public Auction Auction { get; set; }

public Guid AuctionId { get; set; }

    }
