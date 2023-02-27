using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.DesktopView;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;

namespace SistemaEspecialista.DesktopUI.Views;

public partial class MainForm : Form
{
    private readonly IProjectRepository _projectRepository;
    public Project LoadedProject { get; set; }

    public MainForm()
    {
        _projectRepository = Program.ServiceProvider.GetRequiredService<IProjectRepository>();
        InitializeComponent();
    }

    private async void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadedProject = new Project { Description = "Teste", Name ="Nome teste"};
        var result = await _projectRepository.Add(LoadedProject, CancellationToken.None);
    }

    private async void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var project = (await _projectRepository.GetAll(CancellationToken.None)).FirstOrDefault();
        LoadedProject = project;
    }

    private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (LoadedProject is not null)
        {
            if (LoadedProject.Id == DefaultValues.IdNullValue)
            {
                var result = await _projectRepository.Add(LoadedProject, CancellationToken.None);
            }
            else
            {
                var result = await _projectRepository.Update(LoadedProject);
            }
        }
    }
}
