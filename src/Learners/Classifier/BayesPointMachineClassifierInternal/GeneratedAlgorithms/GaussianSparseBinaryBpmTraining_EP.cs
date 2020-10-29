// <auto-generated />
#pragma warning disable 1570, 1591

using System;
using Microsoft.ML.Probabilistic;
using Microsoft.ML.Probabilistic.Distributions;
using Microsoft.ML.Probabilistic.Factors;
using Microsoft.ML.Probabilistic.Collections;

namespace Microsoft.ML.Probabilistic.Learners.BayesPointMachineClassifierInternal
{
	public partial class GaussianSparseBinaryBpmTraining_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7 has executed. Set this to false to force re-execution of Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7</summary>
		public bool Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone;
		/// <summary>True if Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6 has executed. Set this to false to force re-execution of Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6</summary>
		public bool Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone;
		/// <summary>True if Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6 has performed initialisation. Set this to false to force re-execution of Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6</summary>
		public bool Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isInitialised;
		/// <summary>True if Changed_InstanceCount_InstanceFeatureCounts has executed. Set this to false to force re-execution of Changed_InstanceCount_InstanceFeatureCounts</summary>
		public bool Changed_InstanceCount_InstanceFeatureCounts_isDone;
		/// <summary>True if Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5 has executed. Set this to false to force re-execution of Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5</summary>
		public bool Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isDone;
		/// <summary>True if Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5 has performed initialisation. Set this to false to force re-execution of Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5</summary>
		public bool Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised;
		/// <summary>True if Changed_InstanceCount has executed. Set this to false to force re-execution of Changed_InstanceCount</summary>
		public bool Changed_InstanceCount_isDone;
		/// <summary>True if Changed_WeightConstraints_WeightPriors has executed. Set this to false to force re-execution of Changed_WeightConstraints_WeightPriors</summary>
		public bool Changed_WeightConstraints_WeightPriors_isDone;
		/// <summary>True if Changed_WeightPriors has executed. Set this to false to force re-execution of Changed_WeightPriors</summary>
		public bool Changed_WeightPriors_isDone;
		/// <summary>True if Constant has executed. Set this to false to force re-execution of Constant</summary>
		public bool Constant_isDone;
		/// <summary>Field backing the FeatureCount property</summary>
		private int featureCount;
		/// <summary>Field backing the FeatureIndexes property</summary>
		private int[][] featureIndexes;
		public DistributionStructArray<Gaussian,double>[] FeatureScores_B;
		public DistributionStructArray<Gaussian,double>[] FeatureScores_F;
		/// <summary>Field backing the FeatureValues property</summary>
		private double[][] featureValues;
		public DistributionStructArray<Gaussian,double>[] IndexedWeights_B;
		/// <summary>Field backing the InstanceCount property</summary>
		private int instanceCount;
		/// <summary>Field backing the InstanceFeatureCounts property</summary>
		private int[] instanceFeatureCounts;
		/// <summary>Field backing the Labels property</summary>
		private bool[] labels;
		public Gaussian[] NoisyScore_F;
		/// <summary>Message from use of 'NoisyScore'</summary>
		public Gaussian[] NoisyScore_use_B;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		public Gaussian[] Score_B;
		public Gaussian[] Score_F;
		/// <summary>Field backing the WeightConstraints property</summary>
		private DistributionStructArray<Gaussian,double> weightConstraints;
		/// <summary>Field backing the WeightPriors property</summary>
		private DistributionStructArray<Gaussian,double> weightPriors;
		public DistributionStructArray<Gaussian,double> Weights_B;
		public DistributionRefArray<DistributionStructArray<Gaussian,double>,double[]> Weights_FeatureIndexes_B;
		public DistributionRefArray<DistributionStructArray<Gaussian,double>,double[]> Weights_FeatureIndexes_F;
		/// <summary>Message to marginal of 'Weights'</summary>
		public DistributionStructArray<Gaussian,double> Weights_marginal_F;
		/// <summary>Messages from uses of 'Weights'</summary>
		public DistributionStructArray<Gaussian,double>[] Weights_uses_B;
		/// <summary>Messages to uses of 'Weights'</summary>
		public DistributionStructArray<Gaussian,double>[] Weights_uses_F;
		#endregion

		#region Properties
		/// <summary>The externally-specified value of 'FeatureCount'</summary>
		public int FeatureCount
		{
			get {
				return this.featureCount;
			}
			set {
				if (this.featureCount!=value) {
					this.featureCount = value;
					this.numberOfIterationsDone = 0;
				}
			}
		}

		/// <summary>The externally-specified value of 'FeatureIndexes'</summary>
		public int[][] FeatureIndexes
		{
			get {
				return this.featureIndexes;
			}
			set {
				if ((value!=null)&&(value.Length!=this.instanceCount)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+this.instanceCount)+" was expected for variable \'FeatureIndexes\'");
				}
				this.featureIndexes = value;
				this.numberOfIterationsDone = 0;
				this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised = false;
				this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = false;
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'FeatureValues'</summary>
		public double[][] FeatureValues
		{
			get {
				return this.featureValues;
			}
			set {
				if ((value!=null)&&(value.Length!=this.instanceCount)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+this.instanceCount)+" was expected for variable \'FeatureValues\'");
				}
				this.featureValues = value;
				this.numberOfIterationsDone = 0;
				this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised = false;
				this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isInitialised = false;
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'InstanceCount'</summary>
		public int InstanceCount
		{
			get {
				return this.instanceCount;
			}
			set {
				if (this.instanceCount!=value) {
					this.instanceCount = value;
					this.numberOfIterationsDone = 0;
					this.Changed_InstanceCount_isDone = false;
					this.Changed_InstanceCount_InstanceFeatureCounts_isDone = false;
					this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isDone = false;
					this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = false;
					this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
				}
			}
		}

		/// <summary>The externally-specified value of 'InstanceFeatureCounts'</summary>
		public int[] InstanceFeatureCounts
		{
			get {
				return this.instanceFeatureCounts;
			}
			set {
				if ((value!=null)&&(value.Length!=this.instanceCount)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+this.instanceCount)+" was expected for variable \'InstanceFeatureCounts\'");
				}
				this.instanceFeatureCounts = value;
				this.numberOfIterationsDone = 0;
				this.Changed_InstanceCount_InstanceFeatureCounts_isDone = false;
				this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isDone = false;
				this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = false;
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'Labels'</summary>
		public bool[] Labels
		{
			get {
				return this.labels;
			}
			set {
				if ((value!=null)&&(value.Length!=this.instanceCount)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+this.instanceCount)+" was expected for variable \'Labels\'");
				}
				this.labels = value;
				this.numberOfIterationsDone = 0;
				this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised = false;
				this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isInitialised = false;
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
		}

		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'WeightConstraints'</summary>
		public DistributionStructArray<Gaussian,double> WeightConstraints
		{
			get {
				return this.weightConstraints;
			}
			set {
				this.weightConstraints = value;
				this.numberOfIterationsDone = 0;
				this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised = false;
				this.Changed_WeightConstraints_WeightPriors_isDone = false;
				this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = false;
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'WeightPriors'</summary>
		public DistributionStructArray<Gaussian,double> WeightPriors
		{
			get {
				return this.weightPriors;
			}
			set {
				this.weightPriors = value;
				this.numberOfIterationsDone = 0;
				this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised = false;
				this.Changed_WeightPriors_isDone = false;
				this.Changed_WeightConstraints_WeightPriors_isDone = false;
				this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = false;
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of FeatureIndexes and FeatureValues and InstanceCount and InstanceFeatureCounts and Labels and numberOfIterations and WeightConstraints and WeightPriors</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		private void Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7(int numberOfIterations)
		{
			if (this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone) {
				return ;
			}
			for(int iteration = this.numberOfIterationsDone; iteration<numberOfIterations; iteration++) {
				for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
					this.Weights_FeatureIndexes_F[InstanceRange] = JaggedSubarrayWithMarginalOp<double>.ItemsAverageConditional<DistributionStructArray<Gaussian,double>,Gaussian,DistributionStructArray<Gaussian,double>>(this.IndexedWeights_B[InstanceRange], this.Weights_uses_F[1], this.Weights_marginal_F, this.featureIndexes, InstanceRange, this.Weights_FeatureIndexes_F[InstanceRange]);
					for(int InstanceFeatureRanges = 0; InstanceFeatureRanges<this.instanceFeatureCounts[InstanceRange]; InstanceFeatureRanges++) {
						this.FeatureScores_F[InstanceRange][InstanceFeatureRanges] = GaussianProductOpBase.ProductAverageConditional(this.featureValues[InstanceRange][InstanceFeatureRanges], this.Weights_FeatureIndexes_F[InstanceRange][InstanceFeatureRanges]);
					}
					this.Score_F[InstanceRange] = FastSumOp.SumAverageConditional(this.FeatureScores_F[InstanceRange]);
					this.NoisyScore_F[InstanceRange] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(this.Score_F[InstanceRange], 1.0);
					this.NoisyScore_use_B[InstanceRange] = IsPositiveOp_Proper.XAverageConditional(Bernoulli.PointMass(this.labels[InstanceRange]), this.NoisyScore_F[InstanceRange]);
					this.Score_B[InstanceRange] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.NoisyScore_use_B[InstanceRange], 1.0);
					this.FeatureScores_B[InstanceRange] = FastSumOp.ArrayAverageConditional<DistributionStructArray<Gaussian,double>>(this.Score_B[InstanceRange], this.Score_F[InstanceRange], this.FeatureScores_F[InstanceRange], this.FeatureScores_B[InstanceRange]);
					for(int InstanceFeatureRanges = 0; InstanceFeatureRanges<this.instanceFeatureCounts[InstanceRange]; InstanceFeatureRanges++) {
						this.IndexedWeights_B[InstanceRange][InstanceFeatureRanges] = GaussianProductOpBase.BAverageConditional(this.FeatureScores_B[InstanceRange][InstanceFeatureRanges], this.featureValues[InstanceRange][InstanceFeatureRanges]);
					}
					this.Weights_marginal_F = JaggedSubarrayWithMarginalOp<double>.MarginalIncrementItems<DistributionStructArray<Gaussian,double>,Gaussian,DistributionStructArray<Gaussian,double>>(this.IndexedWeights_B[InstanceRange], this.Weights_FeatureIndexes_F[InstanceRange], this.featureIndexes, InstanceRange, this.Weights_marginal_F);
				}
				this.OnProgressChanged(new ProgressChangedEventArgs(iteration));
			}
			this.Weights_uses_B[1] = JaggedSubarrayWithMarginalOp<double>.ArrayAverageConditional<DistributionStructArray<Gaussian,double>>(this.Weights_uses_F[1], this.Weights_marginal_F, this.Weights_uses_B[1]);
			this.Weights_B = ReplicateOp_NoDivide.DefAverageConditional<DistributionStructArray<Gaussian,double>>(this.Weights_uses_B, this.Weights_B);
			this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of FeatureIndexes and InstanceCount and InstanceFeatureCounts and numberOfIterationsDecreased and WeightConstraints and WeightPriors and must reset on changes to FeatureValues and Labels</summary>
		/// <param name="initialise">If true, reset messages that initialise loops</param>
		private void Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6(bool initialise)
		{
			if (this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone&&((!initialise)||this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isInitialised)) {
				return ;
			}
			this.Weights_marginal_F = JaggedSubarrayWithMarginalOp<double>.MarginalAverageConditional<DistributionStructArray<Gaussian,double>,Gaussian,DistributionStructArray<Gaussian,double>>(this.Weights_uses_F[1], this.Weights_FeatureIndexes_B, this.featureIndexes, this.Weights_marginal_F);
			this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = true;
			this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isInitialised = true;
		}

		/// <summary>Computations that depend on the observed value of InstanceCount</summary>
		private void Changed_InstanceCount()
		{
			if (this.Changed_InstanceCount_isDone) {
				return ;
			}
			this.Weights_FeatureIndexes_F = new DistributionRefArray<DistributionStructArray<Gaussian,double>,double[]>(this.instanceCount);
			this.FeatureScores_F = new DistributionStructArray<Gaussian,double>[this.instanceCount];
			this.Score_F = new Gaussian[this.instanceCount];
			for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
				this.Score_F[InstanceRange] = Gaussian.Uniform();
			}
			this.NoisyScore_F = new Gaussian[this.instanceCount];
			for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
				this.NoisyScore_F[InstanceRange] = Gaussian.Uniform();
			}
			this.NoisyScore_use_B = new Gaussian[this.instanceCount];
			for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
				this.NoisyScore_use_B[InstanceRange] = Gaussian.Uniform();
			}
			this.Score_B = new Gaussian[this.instanceCount];
			for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
				this.Score_B[InstanceRange] = Gaussian.Uniform();
			}
			this.FeatureScores_B = new DistributionStructArray<Gaussian,double>[this.instanceCount];
			this.IndexedWeights_B = new DistributionStructArray<Gaussian,double>[this.instanceCount];
			this.Weights_FeatureIndexes_B = new DistributionRefArray<DistributionStructArray<Gaussian,double>,double[]>(this.instanceCount);
			this.Changed_InstanceCount_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of InstanceCount and InstanceFeatureCounts</summary>
		private void Changed_InstanceCount_InstanceFeatureCounts()
		{
			if (this.Changed_InstanceCount_InstanceFeatureCounts_isDone) {
				return ;
			}
			for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
				this.Weights_FeatureIndexes_F[InstanceRange] = new DistributionStructArray<Gaussian,double>(this.instanceFeatureCounts[InstanceRange]);
				for(int InstanceFeatureRanges = 0; InstanceFeatureRanges<this.instanceFeatureCounts[InstanceRange]; InstanceFeatureRanges++) {
					this.Weights_FeatureIndexes_F[InstanceRange][InstanceFeatureRanges] = Gaussian.Uniform();
				}
				this.FeatureScores_F[InstanceRange] = new DistributionStructArray<Gaussian,double>(this.instanceFeatureCounts[InstanceRange]);
				for(int InstanceFeatureRanges = 0; InstanceFeatureRanges<this.instanceFeatureCounts[InstanceRange]; InstanceFeatureRanges++) {
					this.FeatureScores_F[InstanceRange][InstanceFeatureRanges] = Gaussian.Uniform();
				}
				this.FeatureScores_B[InstanceRange] = new DistributionStructArray<Gaussian,double>(this.instanceFeatureCounts[InstanceRange]);
				for(int InstanceFeatureRanges = 0; InstanceFeatureRanges<this.instanceFeatureCounts[InstanceRange]; InstanceFeatureRanges++) {
					this.FeatureScores_B[InstanceRange][InstanceFeatureRanges] = Gaussian.Uniform();
				}
				this.IndexedWeights_B[InstanceRange] = new DistributionStructArray<Gaussian,double>(this.instanceFeatureCounts[InstanceRange]);
				this.Weights_FeatureIndexes_B[InstanceRange] = new DistributionStructArray<Gaussian,double>(this.instanceFeatureCounts[InstanceRange]);
			}
			this.Changed_InstanceCount_InstanceFeatureCounts_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of InstanceCount and InstanceFeatureCounts and numberOfIterationsDecreased and must reset on changes to FeatureIndexes and FeatureValues and Labels and WeightConstraints and WeightPriors</summary>
		/// <param name="initialise">If true, reset messages that initialise loops</param>
		private void Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5(bool initialise)
		{
			if (this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isDone&&((!initialise)||this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised)) {
				return ;
			}
			for(int InstanceRange = 0; InstanceRange<this.instanceCount; InstanceRange++) {
				for(int InstanceFeatureRanges = 0; InstanceFeatureRanges<this.instanceFeatureCounts[InstanceRange]; InstanceFeatureRanges++) {
					this.IndexedWeights_B[InstanceRange][InstanceFeatureRanges] = Gaussian.Uniform();
					this.Weights_FeatureIndexes_B[InstanceRange][InstanceFeatureRanges] = Gaussian.Uniform();
				}
			}
			this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isDone = true;
			this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isInitialised = true;
		}

		/// <summary>Computations that depend on the observed value of WeightConstraints and WeightPriors</summary>
		private void Changed_WeightConstraints_WeightPriors()
		{
			if (this.Changed_WeightConstraints_WeightPriors_isDone) {
				return ;
			}
			this.Weights_uses_B[0] = ArrayHelper.SetTo<DistributionStructArray<Gaussian,double>>(this.Weights_uses_B[0], this.weightConstraints);
			this.Weights_uses_F[1] = ReplicateOp_NoDivide.UsesAverageConditional<DistributionStructArray<Gaussian,double>>(this.Weights_uses_B, this.weightPriors, 1, this.Weights_uses_F[1]);
			this.Changed_WeightConstraints_WeightPriors_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of WeightPriors</summary>
		private void Changed_WeightPriors()
		{
			if (this.Changed_WeightPriors_isDone) {
				return ;
			}
			this.Weights_B = ArrayHelper.MakeUniform<DistributionStructArray<Gaussian,double>>(this.weightPriors);
			this.Weights_uses_B[1] = ArrayHelper.MakeUniform<DistributionStructArray<Gaussian,double>>(this.weightPriors);
			this.Weights_uses_B[0] = ArrayHelper.MakeUniform<DistributionStructArray<Gaussian,double>>(this.weightPriors);
			this.Weights_uses_F[1] = ArrayHelper.MakeUniform<DistributionStructArray<Gaussian,double>>(this.weightPriors);
			this.Weights_marginal_F = ArrayHelper.MakeUniform<DistributionStructArray<Gaussian,double>>(this.weightPriors);
			this.Changed_WeightPriors_isDone = true;
		}

		/// <summary>Computations that do not depend on observed values</summary>
		private void Constant()
		{
			if (this.Constant_isDone) {
				return ;
			}
			this.Weights_uses_F = new DistributionStructArray<Gaussian,double>[2];
			this.Weights_uses_B = new DistributionStructArray<Gaussian,double>[2];
			this.Constant_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			if (numberOfIterations!=this.numberOfIterationsDone) {
				if (numberOfIterations<this.numberOfIterationsDone) {
					this.numberOfIterationsDone = 0;
					this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5_isDone = false;
					this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6_isDone = false;
				}
				this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7_isDone = false;
			}
			this.Constant();
			this.Changed_InstanceCount();
			this.Changed_InstanceCount_InstanceFeatureCounts();
			this.Changed_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_Init_FeatureIndexes_FeatureV5(initialise);
			this.Changed_WeightPriors();
			this.Changed_WeightConstraints_WeightPriors();
			this.Changed_FeatureIndexes_InstanceCount_InstanceFeatureCounts_numberOfIterationsDecreased_WeightConstra6(initialise);
			this.Changed_FeatureIndexes_FeatureValues_InstanceCount_InstanceFeatureCounts_Labels_numberOfIterations_W7(numberOfIterations);
			this.numberOfIterationsDone = numberOfIterations;
		}

		/// <summary>Update all marginals, by iterating message-passing the given number of times</summary>
		/// <param name="numberOfIterations">The total number of iterations that should be executed for the current set of observed values.  If this is more than the number already done, only the extra iterations are done.  If this is less than the number already done, message-passing is restarted from the beginning.  Changing the observed values resets the iteration count to 0.</param>
		public void Execute(int numberOfIterations)
		{
			this.Execute(numberOfIterations, true);
		}

		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="InstanceCount") {
				return this.InstanceCount;
			}
			if (variableName=="FeatureCount") {
				return this.FeatureCount;
			}
			if (variableName=="InstanceFeatureCounts") {
				return this.InstanceFeatureCounts;
			}
			if (variableName=="FeatureValues") {
				return this.FeatureValues;
			}
			if (variableName=="FeatureIndexes") {
				return this.FeatureIndexes;
			}
			if (variableName=="WeightPriors") {
				return this.WeightPriors;
			}
			if (variableName=="WeightConstraints") {
				return this.WeightConstraints;
			}
			if (variableName=="Labels") {
				return this.Labels;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="Weights") {
				return this.WeightsMarginal();
			}
			throw new ArgumentException("This class was not built to infer "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName));
		}

		/// <summary>Get the query-specific marginal distribution of a variable.</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName, string query)
		{
			if (query=="Marginal") {
				return this.Marginal(variableName);
			}
			if ((variableName=="Weights")&&(query=="MarginalDividedByPrior")) {
				return this.WeightsMarginalDividedByPrior();
			}
			throw new ArgumentException(((("This class was not built to infer \'"+variableName)+"\' with query \'")+query)+"\'");
		}

		/// <summary>Get the query-specific marginal distribution of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName, string query)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName, query));
		}

		private void OnProgressChanged(ProgressChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid a race condition
			// if the last subscriber unsubscribes immediately after the null check and before the event is raised.
			EventHandler<ProgressChangedEventArgs> handler = this.ProgressChanged;
			if (handler!=null) {
				handler(this, e);
			}
		}

		/// <summary>Reset all messages to their initial values.  Sets NumberOfIterationsDone to 0.</summary>
		public void Reset()
		{
			this.Execute(0);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="InstanceCount") {
				this.InstanceCount = (int)value;
				return ;
			}
			if (variableName=="FeatureCount") {
				this.FeatureCount = (int)value;
				return ;
			}
			if (variableName=="InstanceFeatureCounts") {
				this.InstanceFeatureCounts = (int[])value;
				return ;
			}
			if (variableName=="FeatureValues") {
				this.FeatureValues = (double[][])value;
				return ;
			}
			if (variableName=="FeatureIndexes") {
				this.FeatureIndexes = (int[][])value;
				return ;
			}
			if (variableName=="WeightPriors") {
				this.WeightPriors = (DistributionStructArray<Gaussian,double>)value;
				return ;
			}
			if (variableName=="WeightConstraints") {
				this.WeightConstraints = (DistributionStructArray<Gaussian,double>)value;
				return ;
			}
			if (variableName=="Labels") {
				this.Labels = (bool[])value;
				return ;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Update all marginals, by iterating message-passing an additional number of times</summary>
		/// <param name="additionalIterations">The number of iterations that should be executed, starting from the current message state.  Messages are not reset, even if observed values have changed.</param>
		public void Update(int additionalIterations)
		{
			this.Execute(checked(this.numberOfIterationsDone+additionalIterations), false);
		}

		/// <summary>
		/// Returns the marginal distribution for 'Weights' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> WeightsMarginal()
		{
			return this.Weights_marginal_F;
		}

		/// <summary>
		/// Returns the output message (the posterior divided by the prior) for 'Weights' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The output message (the posterior divided by the prior)</returns>
		public DistributionStructArray<Gaussian,double> WeightsMarginalDividedByPrior()
		{
			return this.Weights_B;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
