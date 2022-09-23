﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;

namespace extendedClipboardTools
{
    [XmlRoot("ClipboardTool")]
    public class ExtendToolDefineSheet
    {
        /// <summary>
        /// Name of Tool. this attribute used for class-name of tool &  filename of define sheet.
        /// </summary>
        [XmlIgnore]
        public String Name { get; set; }
        
        /// <summary>
        /// names to trigger button
        /// </summary>
        public String FaceName { get; set; }

        /// <summary>
        /// description of tool
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// false: give button, true: give checkbox
        /// </summary>
        [XmlAttribute("continuous")]
        [DefaultValue(false)]
        public bool Continuous { get; set; } = false;

        /// <summary>
        /// global script
        /// </summary>
        [XmlElement("Global")]
        [DefaultValue(null)]
        public string GlobalScript { get; set; } = null;

        /// <summary>
        /// Prepare
        /// </summary>
        [XmlElement("Prepare")]
        [DefaultValue(null)]
        public string PrepareScript { get; set; } = null;

        /// <summary>
        /// Script for checker
        /// </summary>
        [XmlElement("Checker")]
        [DefaultValue(null)]
        public string CheckerScript { get; set; } = null;

        /// <summary>
        /// Script for Action
        /// </summary>
        [XmlElement("Action")]
        [DefaultValue(null)]
        public string ActionScript { get; set; } = null;

        /// <summary>
        /// Script for FinishAction
        /// </summary>
        /// <remarks>
        /// FinishAction is an Action that plays on Continuous tool finished.
        /// </remarks>
        [XmlElement("FinishAction")]
        [DefaultValue(null)]
        public string FinishActionScript { get; set; } = null;
    }
}
