using System.Collections.Generic;
using System.Linq;

namespace XF.Local.AlunoViewModel
{
    class AlunoViewModel
    {
        public AlunoViewModel() { }
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<AlunoViewModel> Alunos
        {
            get
            {
                return App.AlunoModel.GetAlunos().ToList();
            }
        }
        #endregion
    }
}
