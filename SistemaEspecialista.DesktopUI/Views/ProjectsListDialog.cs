using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views;

public partial class ProjectsListDialog : Form
{
    public Project Project { get; set; }

    private readonly IProjectRepository _projectRepository;

    public ProjectsListDialog(IProjectRepository projectRepository)
    {
        InitializeComponent();
        _projectRepository = projectRepository;
        InitializeDialog();
    }

    public async void InitializeDialog()
    {
        dgvProjects.DataSource = await _projectRepository.GetAll(CancellationToken.None);
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        if (dgvProjects.SelectedRows.Count > 0)
        {
            Project = (Project)dgvProjects.SelectedRows[0].DataBoundItem;
            projectNameLbl.Text = $"Projeto selecionado: {Project.Name}";
        }
        else
        {
            Project = (Project)dgvProjects.Rows[dgvProjects.SelectedCells[0].RowIndex].DataBoundItem;
            projectNameLbl.Text = $"Projeto selecionado: {Project.Name}";
        }
    }
}
