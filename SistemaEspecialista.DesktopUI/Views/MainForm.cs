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

    #region Menu

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (NewProjectDialog form = new NewProjectDialog(_projectRepository))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadedProject = form.Project;
                Text = $"{AppConstants.AppTitle} ({LoadedProject.Name})";
            }
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (ProjectsListDialog form = new ProjectsListDialog(_projectRepository))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadedProject = form.Project;
                Text = $"{AppConstants.AppTitle} ({LoadedProject.Name})";
            }
        }
    }

    private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }
    private void manualToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void devsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region Objectives Tab

    private void addObjectiveButton_Click(object sender, EventArgs e)
    {

    }

    private void editObjectiveButton_Click(object sender, EventArgs e)
    {

    }

    private void deleteObjectiveButton_Click(object sender, EventArgs e)
    {

    }

    private void refreshObjectiveListButton_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region Characteristics Tab

    private void refreshCharacteristicsListButton_Click(object sender, EventArgs e)
    {

    }

    private void addCharacteristicButton_Click(object sender, EventArgs e)
    {

    }

    private void editCharacteristicButton_Click(object sender, EventArgs e)
    {

    }

    private void deleteCharacteristicButton_Click(object sender, EventArgs e)
    {

    }

    #endregion

}
