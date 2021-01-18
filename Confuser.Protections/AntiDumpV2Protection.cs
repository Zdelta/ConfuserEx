﻿using System.Linq;
using Confuser.Core;
using Confuser.Core.Helpers;
using Confuser.Core.Services;
using Confuser.Renamer;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Confuser.Protections {

	[BeforeProtection("Ki.ControlFlow")]
	internal class AntiDumpV2Protection : Protection {
		public const string _Id = "Anti Dump";
		public const string _FullId = "Ki.AntiDump";

		public override string Name => "Anti Dump Protection";
		public override string Description => "This protection prevents memory dumping.";
		public override string Id => _Id;
		public override string FullId => _FullId;

		public override ProtectionPreset Preset => ProtectionPreset.Maximum;

		protected override void Initialize(ConfuserContext context) {
			// Null
		}

		protected override void PopulatePipeline(ProtectionPipeline pipeline) {
			pipeline.InsertPreStage(PipelineStage.ProcessModule, new AntiDumpV2Phase(this));
		}

		private class AntiDumpV2Phase : ProtectionPhase {

			public AntiDumpV2Phase(AntiDumpV2Protection parent) : base(parent) {
				// Null
			}

			public override ProtectionTargets Targets => ProtectionTargets.Modules;

			public override string Name => "Anti Dump Injection";

			protected override void Execute(ConfuserContext context, ProtectionParameters parameters) {
				var rtType = context.Registry.GetService<IRuntimeService>().GetRuntimeType("Confuser.Runtime.AntiDumpV2");
				var marker = context.Registry.GetService<IMarkerService>();
				var name = context.Registry.GetService<INameService>();

				foreach (var module in parameters.Targets.OfType<ModuleDef>()) {
					var members = InjectHelper.Inject(rtType, module.GlobalType, module);
					var cctor = module.GlobalType.FindStaticConstructor();
					var init = (MethodDef)members.Single(method => method.Name == "Initialize");

					cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, init));

					foreach (var member in members)
						name.MarkHelper(member, marker, (Protection)Parent);
				}
			}
		}
	}
}
