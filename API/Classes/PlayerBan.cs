﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustalorc.GlobalBan.API.Classes
{
    public class PlayerBan
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public ulong PlayerId { get; set; }

        [Required] public uint Ip { get; set; }

        [Required]
        [StringLength(64)]
        [DefaultValue("")]
        public string Hwid { get; set; }

        [Required]
        [DefaultValue(0ul)]
        public ulong AdminId { get; set; }

        [Required]
        [StringLength(512)]
        [DefaultValue("N/A")]
        public string Reason { get; set; }

        [Required]
        [DefaultValue(uint.MaxValue)]
        public uint Duration { get; set; }

        [Required] public int ServerId { get; set; }

        [Required] public DateTime TimeOfBan { get; set; }

        [Required] [DefaultValue(false)] public bool IsUnbanned { get; set; }
    }
}