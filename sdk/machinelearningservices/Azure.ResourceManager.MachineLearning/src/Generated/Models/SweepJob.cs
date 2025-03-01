// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Sweep job definition. </summary>
    public partial class SweepJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of SweepJob. </summary>
        /// <param name="objective"> [Required] Optimization objective. </param>
        /// <param name="samplingAlgorithm"> [Required] The hyperparameter sampling algorithm. </param>
        /// <param name="searchSpace"> [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter. </param>
        /// <param name="trial"> [Required] Trial component definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objective"/>, <paramref name="samplingAlgorithm"/>, <paramref name="searchSpace"/> or <paramref name="trial"/> is null. </exception>
        public SweepJob(Objective objective, SamplingAlgorithm samplingAlgorithm, BinaryData searchSpace, TrialComponent trial)
        {
            if (objective == null)
            {
                throw new ArgumentNullException(nameof(objective));
            }
            if (samplingAlgorithm == null)
            {
                throw new ArgumentNullException(nameof(samplingAlgorithm));
            }
            if (searchSpace == null)
            {
                throw new ArgumentNullException(nameof(searchSpace));
            }
            if (trial == null)
            {
                throw new ArgumentNullException(nameof(trial));
            }

            Inputs = new ChangeTrackingDictionary<string, JobInput>();
            Objective = objective;
            Outputs = new ChangeTrackingDictionary<string, JobOutput>();
            SamplingAlgorithm = samplingAlgorithm;
            SearchSpace = searchSpace;
            Trial = trial;
            JobType = JobType.Sweep;
        }

        /// <summary> Initializes a new instance of SweepJob. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the &quot;Default&quot; experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="schedule">
        /// Schedule definition of job.
        /// If no schedule is provided, the job is run once and immediately after submission.
        /// </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="earlyTermination"> Early termination policies enable canceling poor-performing runs before they complete. </param>
        /// <param name="inputs"> Mapping of input data bindings used in the job. </param>
        /// <param name="limits"> Sweep Job limit. </param>
        /// <param name="objective"> [Required] Optimization objective. </param>
        /// <param name="outputs"> Mapping of output data bindings used in the job. </param>
        /// <param name="samplingAlgorithm"> [Required] The hyperparameter sampling algorithm. </param>
        /// <param name="searchSpace"> [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter. </param>
        /// <param name="trial"> [Required] Trial component definition. </param>
        internal SweepJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, string computeId, string displayName, string experimentName, IdentityConfiguration identity, bool? isArchived, JobType jobType, ScheduleBase schedule, IDictionary<string, JobService> services, JobStatus? status, EarlyTerminationPolicy earlyTermination, IDictionary<string, JobInput> inputs, SweepJobLimits limits, Objective objective, IDictionary<string, JobOutput> outputs, SamplingAlgorithm samplingAlgorithm, BinaryData searchSpace, TrialComponent trial) : base(description, properties, tags, computeId, displayName, experimentName, identity, isArchived, jobType, schedule, services, status)
        {
            EarlyTermination = earlyTermination;
            Inputs = inputs;
            Limits = limits;
            Objective = objective;
            Outputs = outputs;
            SamplingAlgorithm = samplingAlgorithm;
            SearchSpace = searchSpace;
            Trial = trial;
            JobType = jobType;
        }

        /// <summary> Early termination policies enable canceling poor-performing runs before they complete. </summary>
        public EarlyTerminationPolicy EarlyTermination { get; set; }
        /// <summary> Mapping of input data bindings used in the job. </summary>
        public IDictionary<string, JobInput> Inputs { get; set; }
        /// <summary> Sweep Job limit. </summary>
        public SweepJobLimits Limits { get; set; }
        /// <summary> [Required] Optimization objective. </summary>
        public Objective Objective { get; set; }
        /// <summary> Mapping of output data bindings used in the job. </summary>
        public IDictionary<string, JobOutput> Outputs { get; set; }
        /// <summary> [Required] The hyperparameter sampling algorithm. </summary>
        public SamplingAlgorithm SamplingAlgorithm { get; set; }
        /// <summary> [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter. </summary>
        public BinaryData SearchSpace { get; set; }
        /// <summary> [Required] Trial component definition. </summary>
        public TrialComponent Trial { get; set; }
    }
}
