﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.ViewModels
{
    public class CellphoneListViewModel
    {
        public int ProductId { get; set; }
        public int CellphoneId { get; set; }

        [Display(Name = "نام کالا")]
        public string Name { get; set; }

        [Display(Name = "نقد و بررسی")]
        public string Description { get; set; }

        [Display(Name = "ابعاد")]
        public string Size { get; set; }

        [Display(Name = "وزن")]
        public int Weight { get; set; }

        [Display(Name = "توصیحات سیمکارت")]
        public string SimcardDesc { get; set; }

        [Display(Name = "تعداد سیمکارت")]
        public int SimcardCount { get; set; }

        [Display(Name = "تراشه")]
        public string CpuChipset { get; set; }

        [Display(Name = "پردازنده‌ی مرکزی")]
        public string CpuCore { get; set; }

        [Display(Name = "نوع پردازنده")]
        public string CpuType { get; set; }

        [Display(Name = "فرکانس پردازنده‌ی مرکزی")]
        public string CpuFrequency { get; set; }

        [Display(Name = "پردازنده‌ی گرافیکی")]
        public string GPU { get; set; }

        //حافظه
        [Display(Name = "مقدار RAM")]
        public int RAM { get; set; }

        [Display(Name = "حافظه داخلی")]
        public int Storage { get; set; }

        [Display(Name = "حداکثر ظرفیت کارت حافظه")]
        public int StorageSupport { get; set; }

        [Display(Name = "پشتیبانی از کارت حافظه جانبی")]
        public string StorageType { get; set; }

        //صفحه نمایش
        [Display(Name = "نوع")]
        public string ScreenType { get; set; }

        [Display(Name = "فناوری")]
        public string ScreenTechnology { get; set; }

        [Display(Name = "اندازه")]  
        public string ScreenSize { get; set; }

        [Display(Name = "محافظ")]
        public string ScreenProtector { get; set; }

        [Display(Name = "شبکه‌های ارتباطی")]
        public string ConnectionNetworks { get; set; }

        [Display(Name = "فن‌آوری‌های ارتباطی")]
        public string ConnectionTechnologies { get; set; }


        [Display(Name = "دوربین")]
        public string CameraHas { get; set; }

        [Display(Name = "رزولوشن عکس")]
        public string CameraResolution { get; set; }

        [Display(Name = "فیلمبرداری")]
        public string CameraRecording { get; set; }

        [Display(Name = "سیستم عامل")]
        public string OS { get; set; }

        [Display(Name = "نسخه سیستم عامل")]
        public string OSVersion { get; set; }
    }
}
