using System.Drawing;
using System.Windows.Forms;

public static class DataGridFormatter
{
    /// <summary>
    /// Formata um DataGridView com configurações padrão
    /// </summary>
    /// <param name="grid">DataGridView a ser formatado</param>
    /// <param name="alternateRowColors">Se verdadeiro, alterna cores das linhas</param>
    /// <param name="headerBackgroundColor">Cor de fundo do cabeçalho (null para padrão)</param>
    /// <param name="headerForeColor">Cor do texto do cabeçalho (null para padrão)</param>
    /// <param name="font">Fonte a ser aplicada (null para padrão)</param>
    /// <param name="allowUserToResizeRows">Permite redimensionamento de linhas pelo usuário</param>
    /// <param name="autoSizeColumnsMode">Modo de dimensionamento automático das colunas</param>
    /// <param name="readOnly">Se o grid deve ser somente leitura</param>
    /// <param name="selectionMode">Modo de seleção (FullRowSelect, CellSelect, etc.)</param>
    public static void FormatGrid(DataGridView grid,
        bool alternaCoresLinhas = true,
        Color? headerBackgroundColor = null,
        Color? headerForeColor = null,
        Font font = null,
        bool allowUserToResizeRows = false,
        DataGridViewAutoSizeColumnsMode autoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        bool readOnly = true,
        DataGridViewSelectionMode selectionMode = DataGridViewSelectionMode.FullRowSelect)
    {
        // Configurações básicas
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.ReadOnly = readOnly;
        grid.SelectionMode = selectionMode;
        grid.AutoSizeColumnsMode = autoSizeColumnsMode;
        grid.AllowUserToResizeRows = allowUserToResizeRows;
        grid.RowHeadersVisible = false;
        grid.MultiSelect = false;

        // Aplica fonte se fornecida
        if (font != null)
        {
            grid.Font = font;
        }

        // Cores do cabeçalho
        if (headerBackgroundColor.HasValue)
        {
            grid.ColumnHeadersDefaultCellStyle.BackColor = headerBackgroundColor.Value;
        }

        if (headerForeColor.HasValue)
        {
            grid.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor.Value;
        }

        // Estilo do cabeçalho
        grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        // Cores alternadas das linhas
        if (alternaCoresLinhas)
        {
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        // Seleção
        grid.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;

        // Grade
        grid.GridColor = Color.Gainsboro;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.BorderStyle = BorderStyle.FixedSingle;

        
    }

    /// <summary>
    /// Formata uma coluna específica do DataGridView
    /// </summary>
    /// <param name="grid">DataGridView que contém a coluna</param>
    /// <param name="columnName">Nome da coluna a formatar</param>
    /// <param name="headerText">Texto do cabeçalho (null para manter original)</param>
    /// <param name="textAlign">Alinhamento do texto (null para padrão)</param>
    /// <param name="format">Formato para valores (ex: "N2" para números)</param>
    /// <param name="width">Largura da coluna (-1 para automático)</param>
    public static void FormatColumn(DataGridView grid, string columnName,
        string headerText = null,
        DataGridViewContentAlignment? textAlign = null,
        string format = null,
        int width = -1)
    {
        if (grid.Columns.Contains(columnName))
        {
            var column = grid.Columns[columnName];

            if (headerText != null)
            {
                column.HeaderText = headerText;
            }

            if (textAlign.HasValue)
            {
                column.DefaultCellStyle.Alignment = textAlign.Value;
                column.HeaderCell.Style.Alignment = textAlign.Value;
            }

            if (!string.IsNullOrEmpty(format))
            {
                column.DefaultCellStyle.Format = format;
            }

            if (width >= 0)
            {
                column.Width = width;
            }
        }
    }
    
}
