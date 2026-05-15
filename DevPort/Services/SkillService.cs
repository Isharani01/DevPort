using DevPort.Data;
using DevPort.Models;
using Microsoft.EntityFrameworkCore;

namespace DevPort.Services
{
    public class SkillService
    {
        private readonly ApplicationDbContext _context;

        public SkillService(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET ALL SKILLS (simple version)
        public async Task<List<Skill>> GetSkills()
        {
            return await _context.Skills.ToListAsync();
        }

        // ADD SKILL
        public async Task AddSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            await _context.SaveChangesAsync();
        }

        // DELETE SKILL
        public async Task DeleteSkill(int id)
        {
            var skill = await _context.Skills.FindAsync(id);

            if (skill != null)
            {
                _context.Skills.Remove(skill);
                await _context.SaveChangesAsync();
            }
        }
    }
}