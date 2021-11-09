using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PBKDF2BlazorServerApp.Features.Pbkdf2
{
    public class Pbkdf2Model
    {
        [Required]
        public string TextToHash { get; set; }

        [Required]
        public string SaltBase64 { get; set; }

        public int? SaltSizeBytes { get; set; } = 16; // Keycloak uses 16 bytes as default.

        [Required]
        public int IterationCount { get; set; } = 27500; // Keycloak uses 27500 iterations as default.

        [Required]
        public int HashSizeBytes { get; set; } = 64; // Keycloak uses 64 bytes (512 bits) as default.
    }
}
