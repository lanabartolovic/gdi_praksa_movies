﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Projection
    {
        public long Id { get; set; }

        [ForeignKey("Movie")]

        public long MovieId { get; set; }

        public Movie Movie { get; set; }

        [ForeignKey("MovieTheatre")]

        public long MovieTheatreId { get; set; }

        public MovieTheatre MovieTheatre { get; set; }

        public DateTime ProjectionDateTime { get; set; }

        [ForeignKey("ProjectionType")]
        public long ProjectionTypeId { get; set; }
        public ProjectionType ProjectionType { get; set; }
    }
}
