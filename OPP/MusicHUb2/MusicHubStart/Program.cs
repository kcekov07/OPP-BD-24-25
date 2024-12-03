using Microsoft.EntityFrameworkCore;
using MusicHubStart.MusicHub.Data.Models_;
using StartUp.MusicHub.Data.Models;
using static StartUp.MusicHub.Data.Models.Song;

namespace MusicHubStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<MusicDbContext>()
                .UseInMemoryDatabase(databaseName: "MusicDatabase")
                .Options;

            using (var context = new MusicDbContext(options))
            {
                // Меню за попълване на базата
                while (true)
                {
                    Console.WriteLine("1. Add Producer");
                    Console.WriteLine("2. Add Album");
                    Console.WriteLine("3. Add Writer");
                    Console.WriteLine("4. Add Song");
                    Console.WriteLine("5. ShowWriters");
                    Console.WriteLine("6. ShowAlbums");
                    Console.WriteLine("7. Export Albums Info");
                    Console.WriteLine("8. Exit");
                    Console.Write("Choose an option: ");
                    int choice = int.Parse(Console.ReadLine() ?? "6");

                    switch (choice)
                    {
                        case 1:
                            AddProducer(context);
                            break;
                        case 2:
                            AddAlbum(context);
                            break;
                        case 3:
                            AddWriter(context);
                            break;
                        case 4:
                            AddSong(context);
                            break;
                        case 5:
                            ShowWriters(context);
                            break;
                        case 6:
                            ShowAlbums(context);
                            break;
                        case 7:
                            Console.Write("Enter Producer ID: ");
                            int producerId = int.Parse(Console.ReadLine() ?? "0");
                            string result =ExportAlbumsInfo(context, producerId);
                            Console.WriteLine(result);
                            break;
                        case 8:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                    SaveChangesToDatabase(context);
                }
            }
        }
        private static void SaveChangesToDatabase(MusicDbContext context)
        {
            try
            {
                int changes = context.SaveChanges();
                Console.WriteLine($"{changes} changes saved to the database successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving changes to the database: {ex.Message}");
            }
        }

        private static void ShowWriters(MusicDbContext context)
        {
            Console.WriteLine("Available Writers:");
            var writers = context.Writers.ToList();

            if (writers.Count == 0)
            {
                Console.WriteLine("No writers available.");
            }
            else
            {
                foreach (var writer in writers)
                {
                    Console.WriteLine($"{writer.Id}. {writer.Name} (Pseudonym: {writer.Pseudonym})");
                }
            }
        }

        private static void ShowAlbums(MusicDbContext context)
        {
            Console.WriteLine("Available Albums:");
            var albums = context.Albums.ToList();

            if (albums.Count == 0)
            {
                Console.WriteLine("No albums available.");
            }
            else
            {
                foreach (var album in albums)
                {
                    Console.WriteLine($"{album.Id}. {album.Name} - Released: {album.ReleaseDate.ToString("MM/dd/yyyy")}");
                }
            }
        }

        private static void AddProducer(MusicDbContext context)
        {
            // Въвеждаме данни за продуцент
            Console.Write("Enter Producer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Producer Pseudonym: ");
            string pseudonym = Console.ReadLine();

            Console.Write("Enter Producer Phone Number: ");
            string phoneNumber = Console.ReadLine();

            // Създаване на нов обект Producer със всички задължителни полета
            var producer = new Producer
            {

                Name = name,
                Pseudonym = pseudonym,
                PhoneNumber = phoneNumber
            };

            context.Producers.Add(producer);
            context.SaveChanges();

            try
            {
                context.SaveChanges();
                Console.WriteLine("Producer added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding producer: {ex.Message}");
            }
        }

        private static void AddAlbum(MusicDbContext context)
        {
            Console.Write("Enter Album Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Release Date (MM/dd/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime releaseDate))
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.Write("Enter Producer ID: ");
            if (!int.TryParse(Console.ReadLine(), out int producerId))
            {
                Console.WriteLine("Invalid Producer ID.");
                return;
            }

            // Проверка за наличието на продуцент в базата
            var producer = context.Producers.Find(producerId);
            if (producer == null)
            {
                Console.WriteLine($"Producer with ID {producerId} not found.");
                return;
            }

            // Създаваме новия албум
            var album = new Album
            {
                Name = name,
                ReleaseDate = releaseDate,
                ProducerId = producerId, // Използваме външния ключ ProducerId
                Producer = producer // Свързваме с Producer
            };

            context.Albums.Add(album);

            try
            {
                context.SaveChanges();
                Console.WriteLine($"Album '{name}' added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding album: {ex.Message}");
            }
        }

        private static void AddWriter(MusicDbContext context)
        {
            // Въвеждаме данни за писателя
            Console.Write("Enter Writer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Writer Pseudonym: ");
            string pseudonym = Console.ReadLine();

            // Създаване на нов обект Writer с всички задължителни полета
            var writer = new Writer
            {
                Name = name,
                Pseudonym = pseudonym
            };

            // Добавяме писателя в контекста
            context.Writers.Add(writer);

            try
            {
                // Записваме промените в базата данни
                context.SaveChanges();
                Console.WriteLine("Writer added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding writer: {ex.Message}");
            }
        }

        private static void AddSong(MusicDbContext context)
        {
            Console.Write("Enter Song Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Duration in Minutes: ");
            if (!int.TryParse(Console.ReadLine(), out int minutes))
            {
                Console.WriteLine("Invalid duration.");
                return;
            }

            Console.Write("Enter Created On Date (MM/dd/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime createdOn))
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.Write("Enter Genre (Blues, Rap, PopMusic, Rock, Jazz): ");
            if (!Enum.TryParse(Console.ReadLine(), out Genre genre))
            {
                Console.WriteLine("Invalid genre.");
                return;
            }

            ShowAlbums(context);
            Console.Write("Enter the Album ID from the list above: ");
            int albumId = int.Parse(Console.ReadLine());

            // Показваме наличните писатели и позволяваме избор на потребителя
            ShowWriters(context);
            Console.Write("Enter the Writer ID from the list above: ");
            int writerId = int.Parse(Console.ReadLine());
            // Проверка за наличието на писател в базата
            var writer = context.Writers.Find(writerId);
            if (writer == null)
            {
                Console.WriteLine($"Writer with ID {writerId} not found.");
                return;
            }

            Console.Write("Enter Price for the Song: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Invalid price.");
                return;
            }

            // Създаваме песента
            var song = new Song
            {
                Name = name,
                Duration = TimeSpan.FromMinutes(minutes),
                CreatedOn = createdOn,
                genre = genre,
                AlbumId = albumId, // Свързваме песента с албума
                WriterId = writerId, // Свързваме песента с писателя
                Price = price
            };

            context.Songs.Add(song);

            try
            {
                context.SaveChanges();
                Console.WriteLine($"Song '{name}' added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding song: {ex.Message}");
            }
        }




        public static string ExportAlbumsInfo(MusicDbContext context, int producerId)
        {
            var albums = context.Albums
                .Where(a => a.Producer.Id == producerId) // Филтрираме по дадения ProducerId
                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = a.Producer.Name,
                    Songs = a.Songs
                        .Select(s => new
                        {
                            SongName = s.Name,
                            Price = s.Price,
                            WriterName = s.Writer.Name
                        })
                        .OrderByDescending(s => s.SongName) // Сортиране на песните по име (низходящо)
                        .ThenBy(s => s.WriterName)         // След това по име на автора (възходящо)
                        .ToList(),
                    TotalPrice = a.Songs.Sum(s => s.Price) // Изчисляване на общата цена на албума
                })
                .OrderByDescending(a => a.TotalPrice) // Сортиране на албумите по обща цена (низходящо)
                .ToList();

            if (!albums.Any())
            {
                return "No albums found for this producer.";
            }

            var result = "";
            foreach (var album in albums)
            {
                result += $"Album: {album.AlbumName}\n";
                result += $"Release Date: {album.ReleaseDate}\n";
                result += $"Producer: {album.ProducerName}\n";
                result += $"Songs:\n";

                foreach (var song in album.Songs)
                {
                    result += $"---Song Name: {song.SongName}\n";
                    result += $"---Price: {song.Price:F2}\n"; // Форматираме цената до две цифри
                    result += $"---Writer: {song.WriterName}\n";
                }

                result += $"Total Album Price: {album.TotalPrice:F2}\n"; // Форматираме общата цена
            }

            return result;
        }
    }
}

