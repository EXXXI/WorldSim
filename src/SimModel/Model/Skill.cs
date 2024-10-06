using System.Collections.Generic;
using System.Linq;

namespace SimModel.Model
{
    /// <summary>
    /// �X�L��
    /// </summary>
    public record Skill
    {

        /// <summary>
        /// �X�L����
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// �X�L�����x��
        /// </summary>
        public int Level { get; set; } = 0;

        /// <summary>
        /// �Œ茟���t���O
        /// </summary>
        public bool IsFixed { get; set; } = false;

        /// <summary>
        /// �X�L���̃J�e�S��
        /// </summary>
        public string Category { get; init; }

        /// <summary>
        /// �V���[�Y�X�L�����A���x���ɓ���Ȗ��̂�����ꍇ�����Ɋi�[
        /// </summary>
        public Dictionary<int, string> SpecificNames { get; }

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="name">�X�L����</param>
        /// <param name="level">���x��</param>
        /// <param name="isFixed">�Œ茟���t���O</param>
        public Skill(string name, int level, bool isFixed = false) 
            : this(name, level, Masters.Skills.Where(s => s.Name == name).FirstOrDefault()?.Category, isFixed) { }

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="name">�X�L����</param>
        /// <param name="level">���x��</param>
        /// <param name="category">�J�e�S��</param>
        /// <param name="isFixed">�Œ茟���t���O</param>
        public Skill(string name, int level, string? category, bool isFixed = false)
        {
            Name = name;
            Level = level;
            IsFixed = isFixed;
            Category = string.IsNullOrEmpty(category) ? @"������" : category;
            SpecificNames = Masters.Skills.Where(s => s.Name == name).Select(s => s.SpecificNames).FirstOrDefault() ?? new();
        }

        /// <summary>
        /// �ő僌�x��
        /// �}�X�^�ɑ��݂��Ȃ��X�L���̏ꍇ0
        /// </summary>
        public int MaxLevel {
            get 
            {
                return Masters.SkillMaxLevel(Name);
            }
        }

        /// <summary>
        /// �\���p������
        /// </summary>
        public string Description
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name) || Level == 0)
                {
                    return string.Empty;
                }
                return SpecificNames.ContainsKey(Level) ? SpecificNames[Level] : $"{Name}Lv{Level}";
            }
        }
    }
}
