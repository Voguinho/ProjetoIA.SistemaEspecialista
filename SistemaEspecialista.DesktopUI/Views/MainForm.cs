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

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadedProject = new Project();

    }

    private async void editToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (LoadedProject.Id != DefaultValues.IdNullValue)
        {
            var result = _projectRepository.Add(LoadedProject, CancellationToken.None);
        }
        else
        {
            var result = _projectRepository.Update(LoadedProject);
        }
    }
}
