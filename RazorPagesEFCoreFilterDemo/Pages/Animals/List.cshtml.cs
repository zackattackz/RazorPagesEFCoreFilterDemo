using FS.FilterExpressionCreator.Filters;
using FS.FilterExpressionCreator.Enums;
using FS.FilterExpressionCreator.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEFCoreFilterDemo.Data.Repositories;
using RazorPagesEFCoreFilterDemo.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace RazorPagesEFCoreFilterDemo.Pages.Animals
{
    public class ListModel : PageModel
    {
        private readonly IZooRepository _repository;

        public ListModel(IZooRepository repository)
        {
            _repository = repository;
        }

        [FromQuery(Name = "pgno")]
        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        public IEnumerable<Animal> Animals { get; set; } = Array.Empty<Animal>();

        private EntityFilter<Animal> GetExampleFilter(int id)
        {
            EntityFilter<Mammal>? mammalFilter;
            EntityFilter<Reptile>? reptileFilter;
            EntityFilter<Canine>? canineFilter;
            EntityFilter<Crocodile>? crocodileFilter;
            EntityFilter<Turtle>? turtleFilter;

            switch (id)
            {
                case 1:
                    // All Animals
                    return new EntityFilter<Animal>();
                case 2:
                    // Only Mammals
                    mammalFilter = new EntityFilter<Mammal>();
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(mammalFilter);
                case 3:
                    // Only Female Mammals
                    mammalFilter = new EntityFilter<Mammal>()
                        .Add(m => m.Sex, ValueFilter.Create("=F"));
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(mammalFilter);
                case 4:
                    // Only Female Mammals, but include all other animals
                    mammalFilter = new EntityFilter<Mammal>()
                        .Add(m => m.Sex, ValueFilter.Create("=F"));
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(mammalFilter, isInclusive: true);
                case 5:
                    // Only Female Mammals or Only Male Reptiles
                    mammalFilter = new EntityFilter<Mammal>()
                        .Add(m => m.Sex, ValueFilter.Create("=F"));
                    reptileFilter = new EntityFilter<Reptile>()
                        .Add(r => r.Sex, ValueFilter.Create("=M"));
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(mammalFilter)
                        .AddSubclassFilter(reptileFilter);
                case 6:
                    // Only Canines
                    canineFilter = new EntityFilter<Canine>();
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(canineFilter);
                case 7:
                    // Only Turtles with a ScaleHardness > 10 and a ShellHardness > 10
                    turtleFilter = new EntityFilter<Turtle>()
                        .Add(t => t.ScaleHardness, FilterOperator.GreaterThan, 10)
                        .Add(t => t.ShellHardness, FilterOperator.GreaterThan, 10);
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(turtleFilter);
                case 8:
                    // Only Reptiles with ScaleHardness > 10, only Turtles with a ShellHardness > 10, only Crocodiles with a BiteForce < 10
                    turtleFilter = new EntityFilter<Turtle>()
                        .Add(t => t.ShellHardness, FilterOperator.GreaterThan, 10);
                    crocodileFilter = new EntityFilter<Crocodile>()
                        .Add(c => c.BiteForce, FilterOperator.LessThan, 10);
                    reptileFilter = new EntityFilter<Reptile>()
                        .Add(r => r.ScaleHardness, FilterOperator.GreaterThan, 10)
                        .AddSubclassFilter(turtleFilter)
                        .AddSubclassFilter(crocodileFilter);
                    return new EntityFilter<Animal>()
                        .AddSubclassFilter(reptileFilter);
                default:
                    throw new ArgumentException($"No filter example exists for id={id}.", nameof(id));
            }
        }

        public IActionResult OnGet(int id)
        {
            var animalFilter = GetExampleFilter(id);

            Console.WriteLine(animalFilter);
            Animals = _repository.GetEntriesByPageNo(PageNumber, animalFilter.CreateFilter());

            return Page();
        }
    }
}
