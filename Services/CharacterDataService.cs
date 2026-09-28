using MyWebsite.Models;

namespace MyWebsite.Services;

public class CharacterDataService
{
    public List<Character> GetAllCharacters()
    {
        return new List<Character>
        {
            // --- BACHELORS ---
            new Character
            {
                Id = 1,
                Name = "Sebastian",
                Birthday = "Winter 10",
                FavoriteGift = "Frozen Tear, Obsidian, Void Egg, Sashimi",
                FavoriteSeason = "Winter",
                FavoriteFood = "Sashimi",
                Hobbies = new() { "Coding", "Motorcycle riding", "Tabletop RPGs", "Playing drums" },
                Family = new() { "Robin (Mother)", "Demetrius (Stepfather)", "Maru (Half-sister)" },
                ShortDescription = "A rebellious loner living in his family's basement, working remotely as a programmer.",
                DetailedDescription = "Sebastian often feels overshadowed by his half-sister Maru and struggles with feelings of isolation. Despite his guarded demeanor, he is deeply thoughtful, loves rainy days, and dreams of taking his motorcycle to the big city.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/a/a8/Sebastian.png"
            },
            new Character
            {
                Id = 2,
                Name = "Shane",
                Birthday = "Spring 20",
                FavoriteGift = "Beer, Hot Pepper, Pepper Poppers, Pizza",
                FavoriteSeason = "Fall",
                FavoriteFood = "Pepper Poppers",
                Hobbies = new() { "Caring for chickens", "Watching Gridball", "Drinking at the Stardrop Saloon" },
                Family = new() { "Marnie (Aunt)", "Jas (Goddaughter)" },
                ShortDescription = "A blunt shelf-stocker at JojaMart who retreats into beer and quiet cynicism.",
                DetailedDescription = "Behind Shane's prickly exterior is a deeply sensitive person battling severe depression. Once he lets you in, he reveals his deep love for breeding rare blue chickens and works hard to turn his life around for Jas.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/8/8b/Shane.png"
            },
            new Character
            {
                Id = 3,
                Name = "Elliott",
                Birthday = "Fall 5",
                FavoriteGift = "Duck Feather, Lobster, Pomegranate, Squid Ink",
                FavoriteSeason = "Fall",
                FavoriteFood = "Tom Kha Soup",
                Hobbies = new() { "Writing novels", "Playing piano", "Strolling along the beach" },
                Family = new() { },
                ShortDescription = "A dramatic, romantic writer who lives in an isolated beach cabin by the ocean.",
                DetailedDescription = "Elliott moved to Pelican Town to focus on finishing his debut novel away from urban distractions. He speaks with poetic flair, appreciates fine art, and is fiercely loyal to those who believe in his literary dreams.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/b/bd/Elliott.png"
            },
            new Character
            {
                Id = 4,
                Name = "Harvey",
                Birthday = "Winter 14",
                FavoriteGift = "Coffee, Pickles, Super Meal, Truffle Oil, Wine",
                FavoriteSeason = "Winter",
                FavoriteFood = "Pickles",
                Hobbies = new() { "Aviation models", "Listening to ham radio", "Health and fitness" },
                Family = new() { },
                ShortDescription = "The town's dedicated and somewhat anxious doctor who runs the local medical clinic.",
                DetailedDescription = "Harvey genuinely cares about everyone's wellbeing in the valley, even when business is slow. He harbors a deep, quiet longing for aviation, often spending evenings tuning into aircraft frequencies or building model airplanes.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/9/95/Harvey.png"
            },
            new Character
            {
                Id = 5,
                Name = "Sam",
                Birthday = "Summer 17",
                FavoriteGift = "Cactus Fruit, Maple Bar, Pizza, Tigerseye",
                FavoriteSeason = "Summer",
                FavoriteFood = "Pizza",
                Hobbies = new() { "Skateboarding", "Playing guitar", "Band practice" },
                Family = new() { "Jodi (Mother)", "Kent (Father)", "Vincent (Brother)" },
                ShortDescription = "An upbeat, outgoing musician who plays in a garage band with Sebastian and Abigail.",
                DetailedDescription = "Full of youthful energy and good intentions, Sam can be slightly irresponsible but has an affectionate heart. He cares deeply for his little brother Vincent and works part-time trying to find his musical path in the world.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/9/94/Sam.png"
            },
            new Character
            {
                Id = 6,
                Name = "Alex",
                Birthday = "Summer 13",
                FavoriteGift = "Complete Breakfast, Salmon Dinner",
                FavoriteSeason = "Summer",
                FavoriteFood = "Complete Breakfast",
                Hobbies = new() { "Gridball training", "Weightlifting", "Hanging out at the beach" },
                Family = new() { "George (Grandfather)", "Evelyn (Grandmother)" },
                ShortDescription = "An ambitious jock who dreams of becoming a pro Gridball player.",
                DetailedDescription = "While he can come off as cocky or boastful early on, Alex carries lingering pain from a difficult childhood with his late mother. Beneath the sports bravado, he is sensitive, values family loyalty, and strives to prove his worth.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/0/04/Alex.png"
            },

            // --- BACHELORETTES ---
            new Character
            {
                Id = 7,
                Name = "Abigail",
                Birthday = "Fall 13",
                FavoriteGift = "Amethyst, Banana Pudding, Blackberry Cobbler, Chocolate Cake, Pufferfish, Pumpkin",
                FavoriteSeason = "Fall",
                FavoriteFood = "Spicy Eel",
                Hobbies = new() { "Playing flute", "Exploring the mines", "Video games", "Drumming" },
                Family = new() { "Pierre (Father)", "Caroline (Mother)" },
                ShortDescription = "A spirited, purple-haired tomboy with an interest in the supernatural and swordplay.",
                DetailedDescription = "Abigail clashes frequently with her traditional parents over her nonconformist lifestyle. She refuses to conform to domestic expectations, dreaming of venturing into dangerous caverns with a sword and living freely.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/8/88/Abigail.png"
            },
            new Character
            {
                Id = 8,
                Name = "Leah",
                Birthday = "Winter 23",
                FavoriteGift = "Goat Cheese, Salad, Stir Fry, Truffle, Vegetable Medley, Wine",
                FavoriteSeason = "Fall",
                FavoriteFood = "Salad",
                Hobbies = new() { "Wood sculpting", "Foraging", "Sketching outdoors" },
                Family = new() { },
                ShortDescription = "A free-spirited artist living in a secluded cottage in Cindersap Forest.",
                DetailedDescription = "Leah abandoned a hectic life in the city to pursue her true calling as a wood sculptor. She has a deep spiritual connection with nature, loves gathering wild mushrooms and berries, and sometimes second-guesses whether her art is good enough.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/e/e6/Leah.png"
            },
            new Character
            {
                Id = 9,
                Name = "Haley",
                Birthday = "Spring 14",
                FavoriteGift = "Coconut, Fruit Salad, Pink Cake, Sunflower",
                FavoriteSeason = "Spring",
                FavoriteFood = "Fruit Salad",
                Hobbies = new() { "Photography", "Fashion", "Shopping" },
                Family = new() { "Emily (Sister)" },
                ShortDescription = "A fashionable young woman with a sharp tongue and a passion for high-end photography.",
                DetailedDescription = "Initially superficial and dismissive of small-town farm life, Haley undergoes significant personal growth. She discovers genuine joy in darkroom photography, learns to appreciate simplicity, and develops a warm generosity.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/1/1b/Haley.png"
            },
            new Character
            {
                Id = 10,
                Name = "Maru",
                Birthday = "Summer 10",
                FavoriteGift = "Battery Pack, Cauliflower, Diamond, Gold Bar, Iridium Bar, Miner's Treat, Pepper Poppers, Radioactive Bar, Rhubarb Pie, Strawberry",
                FavoriteSeason = "Summer",
                FavoriteFood = "Rhubarb Pie",
                Hobbies = new() { "Building robotics", "Astronomy", "Electronics soldering" },
                Family = new() { "Demetrius (Father)", "Robin (Mother)", "Sebastian (Half-brother)" },
                ShortDescription = "A brilliant inventor and nurse who builds robots in her parents' workshop.",
                DetailedDescription = "Taking after both her carpenter mother and scientist father, Maru has an insatiable curiosity about how things work. When she is not helping Harvey at the clinic, she stays up late gazing at constellations and designing autonomous machines.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/f/f8/Maru.png"
            },
            new Character
            {
                Id = 11,
                Name = "Penny",
                Birthday = "Fall 2",
                FavoriteGift = "Diamond, Emerald, Melon, Poppy, Poppyseed Muffin, Red Plate, Roots Platter, Sandfish, Tom Kha Soup",
                FavoriteSeason = "Spring",
                FavoriteFood = "Red Plate",
                Hobbies = new() { "Reading books", "Tutoring local children", "Cooking" },
                Family = new() { "Pam (Mother)" },
                ShortDescription = "A kind-hearted, shy teacher who tutors Jas and Vincent under the town tree.",
                DetailedDescription = "Penny lives in a cramped trailer with her alcoholic mother, Pam, and works hard to keep a clean, peaceful home. She is selfless and gentle, finding solace in thick library books and hoping for a warm family life of her own.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/a/ab/Penny.png"
            },
            new Character
            {
                Id = 12,
                Name = "Emily",
                Birthday = "Spring 27",
                FavoriteGift = "Amethyst, Aquamarine, Cloth, Emerald, Jade, Ruby, Survival Burger, Topaz, Wool",
                FavoriteSeason = "Spring",
                FavoriteFood = "Survival Burger",
                Hobbies = new() { "Sewing garments", "Crystal meditation", "Ecstatic dancing" },
                Family = new() { "Haley (Sister)" },
                ShortDescription = "An eccentric, sunny seamstress who works evening shifts at the Stardrop Saloon.",
                DetailedDescription = "Emily sees beauty and spiritual meaning where others see nothing. She hand-makes her own colorful clothes, reads spiritual auras through crystals, and stays remarkably cheerful regardless of circumstances.",
                ImageUrl = "https://stardewvalleywiki.com/mediawiki/images/2/28/Emily.png"
            }
        };
    }
}