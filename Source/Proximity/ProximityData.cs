﻿using System;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace Proximity
{
	// Token: 0x02000005 RID: 5
	public class ProximityData : ThingComp
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002D00 File Offset: 0x00000F00
		public override void PostExposeData()
		{
			base.PostExposeData();
			Scribe_Values.Look<float>(ref this.MoveSpeedOffSet, "Prox_MoveSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.GlobalLearningFactorOffSet, "Prox_GlobalLearningFactorOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.NegotiationAbilityOffSet, "Prox_NegotiationAbilityOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.PsychicSensitivityOffSet, "Prox_PsychicSensitivityOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.SocialImpactOffSet, "Prox_SocialImpactOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ToxicSensitivityOffSet, "Prox_ToxicSensitivityOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ComfyTemperatureMinOffSet, "Prox_ComfyTemperatureMinOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ComfyTemperatureMaxOffSet, "Prox_ComfyTemperatureMaxOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.AimingDelayFactorOffSet, "Prox_AimingDelayFactorOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ShootingAccuracyPawnOffSet, "Prox_ShootingAccuracyPawnOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MeleeDodgeChanceOffSet, "Prox_MeleeDodgeChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MeleeHitChanceOffSet, "Prox_MeleeHitChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ImmunityGainSpeedOffSet, "Prox_ImmunityGainSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MedicalTendSpeedOffSet, "Prox_MedicalTendSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MedicalTendQualityOffSet, "Prox_MedicalTendQualityOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MedicalOperationSpeedOffSet, "Prox_MedicalOperationSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MedicalSurgerySuccessChanceOffSet, "Prox_MedicalSurgerySuccessChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.AnimalGatherSpeedOffSet, "Prox_AnimalGatherSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.AnimalGatherYieldOffSet, "Prox_AnimalGatherYieldOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ConstructionSpeedOffSet, "Prox_ConstructionSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ConstructSuccessChanceOffSet, "Prox_ConstructSuccessChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.EatingSpeedOffSet, "Prox_EatingSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.HuntingStealthOffSet, "Prox_HuntingStealthOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.MiningSpeedOffSet, "Prox_MiningSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.PlantHarvestYieldOffSet, "Prox_PlantHarvestYieldOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.PlantWorkSpeedOffSet, "Prox_PlantWorkSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ResearchSpeedOffSet, "Prox_ResearchSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.SmoothingSpeedOffSet, "Prox_SmoothingSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.TameAnimalChanceOffSet, "Prox_TameAnimalChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.TrainAnimalChanceOffSet, "Prox_TrainAnimalChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.WorkSpeedGlobalOffSet, "Prox_WorkSpeedGlobalOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ButcheryFleshEfficiencyOffSet, "Prox_ButcheryFleshEfficiencyOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ButcheryFleshSpeedOffSet, "Prox_ButcheryFleshSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ButcheryMechanoidEfficiencyOffSet, "Prox_ButcheryMechanoidEfficiencyOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.ButcheryMechanoidSpeedOffSet, "Prox_ButcheryMechanoidSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.CookSpeedOffSet, "Prox_CookSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.DrugCookingSpeedOffSet, "Prox_DrugCookingSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.DrugSynthesisSpeedOffSet, "Prox_DrugSynthesisSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.FixBrokenDownBuildingSuccessChanceOffSet, "Prox_FixBrokenDownBuildingSuccessChanceOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.SmeltingSpeedOffSet, "Prox_SmeltingSpeedOffSet", 0f, false);
			Scribe_Values.Look<float>(ref this.GeneralLaborSpeedOffSet, "Prox_GeneralLaborSpeedOffSet", 0f, false);
			Scribe_Values.Look<int>(ref this.ProxTick, "ProxTick", 0, false);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000030ED File Offset: 0x000012ED
		private Pawn Pawn
		{
			get
			{
				return (Pawn)this.parent;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000030FC File Offset: 0x000012FC
		public override void CompTick()
		{
			if (Find.TickManager.TicksGame > this.ProxTick)
			{
                ProximityStatReset(this.Pawn);
				if (this.Pawn.Map != null)
				{
					List<Thing> list = GenRadial.RadialDistinctThingsAround(this.Pawn.Position, this.Pawn.Map, (float)ProxGlobals.closeRange, true).ToList<Thing>();
					if (list.Count > 0)
					{
						for (int i = 0; i < list.Count; i++)
						{
							Thing thing = list[i];
							if (ProxGlobals.IsNearThingValid(thing, this.Pawn) && ProxGlobals.NearThingEffects(thing, this.Pawn))
							{
								int proxRange = ProximityGet.GetProxRange(thing.def);
								if (ProxGlobals.NearThingInRange(thing, this.Pawn, proxRange))
								{
									ProxGlobals.ProximityHediffEffect(thing, this.Pawn);
                                    ProximityStatSet(thing, this.Pawn);
								}
							}
						}
					}
					if (ProxGlobals.UseTerrain)
					{
						List<IntVec3> list2 = GenRadial.RadialCellsAround(this.Pawn.Position, (float)ProxGlobals.closeRange, true).ToList<IntVec3>();
						if (list2.Count > 0)
						{
							for (int j = 0; j < list2.Count; j++)
							{
								TerrainDef terrainDef = list2[j].InBounds(this.Pawn.Map) ? list2[j].GetTerrain(this.Pawn.Map) : null;
								if (terrainDef != null && list2[j].InBounds(this.Pawn.Map) && ProxGlobals.IsTerrainValid(terrainDef, this.Pawn) && ProxGlobals.TerrainEffects(terrainDef, list2[j], this.Pawn))
								{
									int tproxRange = ProximityGet.GetTProxRange(terrainDef);
									if (ProxGlobals.TerrainInRange(terrainDef, list2[j], this.Pawn, tproxRange))
									{
										ProxGlobals.ProximityTerrainHediffEffect(terrainDef, list2[j], this.Pawn);
                                        ProximityTStatSet(terrainDef, list2[j], this.Pawn);
									}
								}
							}
						}
					}
				}
				this.ProxTick = Find.TickManager.TicksGame + ProxGlobals.ExtendTicks();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000330C File Offset: 0x0000150C
		internal static void ProximityStatReset(Pawn pawn)
		{
			ThingComp thingComp = pawn?.TryGetComp<ProximityData>();
			if (thingComp != null)
			{
                if (thingComp is ProximityData proximityData)
                {
                    proximityData.MoveSpeedOffSet = 0f;
                    proximityData.GlobalLearningFactorOffSet = 0f;
                    proximityData.NegotiationAbilityOffSet = 0f;
                    proximityData.PsychicSensitivityOffSet = 0f;
                    proximityData.SocialImpactOffSet = 0f;
                    proximityData.ToxicSensitivityOffSet = 0f;
                    proximityData.ComfyTemperatureMinOffSet = 0f;
                    proximityData.ComfyTemperatureMaxOffSet = 0f;
                    proximityData.AimingDelayFactorOffSet = 0f;
                    proximityData.ShootingAccuracyPawnOffSet = 0f;
                    proximityData.MeleeDodgeChanceOffSet = 0f;
                    proximityData.MeleeHitChanceOffSet = 0f;
                    proximityData.ImmunityGainSpeedOffSet = 0f;
                    proximityData.MedicalTendSpeedOffSet = 0f;
                    proximityData.MedicalTendQualityOffSet = 0f;
                    proximityData.MedicalOperationSpeedOffSet = 0f;
                    proximityData.MedicalSurgerySuccessChanceOffSet = 0f;
                    proximityData.AnimalGatherSpeedOffSet = 0f;
                    proximityData.AnimalGatherYieldOffSet = 0f;
                    proximityData.ConstructionSpeedOffSet = 0f;
                    proximityData.ConstructSuccessChanceOffSet = 0f;
                    proximityData.EatingSpeedOffSet = 0f;
                    proximityData.HuntingStealthOffSet = 0f;
                    proximityData.MiningSpeedOffSet = 0f;
                    proximityData.PlantHarvestYieldOffSet = 0f;
                    proximityData.PlantWorkSpeedOffSet = 0f;
                    proximityData.ResearchSpeedOffSet = 0f;
                    proximityData.SmoothingSpeedOffSet = 0f;
                    proximityData.TameAnimalChanceOffSet = 0f;
                    proximityData.TrainAnimalChanceOffSet = 0f;
                    proximityData.WorkSpeedGlobalOffSet = 0f;
                    proximityData.ButcheryFleshSpeedOffSet = 0f;
                    proximityData.ButcheryMechanoidSpeedOffSet = 0f;
                    proximityData.ButcheryFleshEfficiencyOffSet = 0f;
                    proximityData.ButcheryMechanoidEfficiencyOffSet = 0f;
                    proximityData.CookSpeedOffSet = 0f;
                    proximityData.DrugCookingSpeedOffSet = 0f;
                    proximityData.DrugSynthesisSpeedOffSet = 0f;
                    proximityData.FixBrokenDownBuildingSuccessChanceOffSet = 0f;
                    proximityData.SmeltingSpeedOffSet = 0f;
                    proximityData.GeneralLaborSpeedOffSet = 0f;
                }
            }
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003520 File Offset: 0x00001720
		internal static void ProximityStatSet(Thing thing, Pawn pawn)
		{
			ThingComp thingComp = pawn?.TryGetComp<ProximityData>();
			if (thingComp != null)
			{
                if (thingComp is ProximityData proximityData)
                {
                    float proxQualFactor = ProxGlobals.GetProxQualFactor(thing);
                    if (ProximityGet.GetProxMoveSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.MoveSpeedOffSet += proxQualFactor * ProximityGet.GetProxMoveSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def) != 0f)
                    {
                        proximityData.GlobalLearningFactorOffSet += proxQualFactor * ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxNegotiationAbilityOffSet(thing.def) != 0f)
                    {
                        proximityData.NegotiationAbilityOffSet += proxQualFactor * ProximityGet.GetProxNegotiationAbilityOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxPsychicSensitivityOffSet(thing.def) != 0f)
                    {
                        proximityData.PsychicSensitivityOffSet += proxQualFactor * ProximityGet.GetProxPsychicSensitivityOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxSocialImpactOffSet(thing.def) != 0f)
                    {
                        proximityData.SocialImpactOffSet += proxQualFactor * ProximityGet.GetProxSocialImpactOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxToxicSensitivityOffSet(thing.def) != 0f)
                    {
                        proximityData.ToxicSensitivityOffSet += proxQualFactor * ProximityGet.GetProxToxicSensitivityOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def) != 0f)
                    {
                        proximityData.ComfyTemperatureMinOffSet += proxQualFactor * ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def) != 0f)
                    {
                        proximityData.ComfyTemperatureMaxOffSet += proxQualFactor * ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxAimingDelayFactorOffSet(thing.def) != 0f)
                    {
                        proximityData.AimingDelayFactorOffSet += proxQualFactor * ProximityGet.GetProxAimingDelayFactorOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def) != 0f)
                    {
                        proximityData.ShootingAccuracyPawnOffSet += proxQualFactor * ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.MeleeDodgeChanceOffSet += proxQualFactor * ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMeleeHitChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.MeleeHitChanceOffSet += proxQualFactor * ProximityGet.GetProxMeleeHitChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.ImmunityGainSpeedOffSet += proxQualFactor * ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.MedicalTendSpeedOffSet += proxQualFactor * ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMedicalTendQualityOffSet(thing.def) != 0f)
                    {
                        proximityData.MedicalTendQualityOffSet += proxQualFactor * ProximityGet.GetProxMedicalTendQualityOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.MedicalOperationSpeedOffSet += proxQualFactor * ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMedicalSurgerySuccessChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.MedicalSurgerySuccessChanceOffSet += proxQualFactor * ProximityGet.GetProxMedicalSurgerySuccessChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.AnimalGatherSpeedOffSet += proxQualFactor * ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def) != 0f)
                    {
                        proximityData.AnimalGatherYieldOffSet += proxQualFactor * ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxConstructionSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.ConstructionSpeedOffSet += proxQualFactor * ProximityGet.GetProxConstructionSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxConstructSuccessChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.ConstructSuccessChanceOffSet += proxQualFactor * ProximityGet.GetProxConstructSuccessChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxEatingSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.EatingSpeedOffSet += proxQualFactor * ProximityGet.GetProxEatingSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxHuntingStealthOffSet(thing.def) != 0f)
                    {
                        proximityData.HuntingStealthOffSet += proxQualFactor * ProximityGet.GetProxHuntingStealthOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxMiningSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.MiningSpeedOffSet += proxQualFactor * ProximityGet.GetProxMiningSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def) != 0f)
                    {
                        proximityData.PlantHarvestYieldOffSet += proxQualFactor * ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.PlantWorkSpeedOffSet += proxQualFactor * ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxResearchSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.ResearchSpeedOffSet += proxQualFactor * ProximityGet.GetProxResearchSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxSmoothingSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.SmoothingSpeedOffSet += proxQualFactor * ProximityGet.GetProxSmoothingSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxTameAnimalChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.TameAnimalChanceOffSet += proxQualFactor * ProximityGet.GetProxTameAnimalChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.TrainAnimalChanceOffSet += proxQualFactor * ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def) != 0f)
                    {
                        proximityData.WorkSpeedGlobalOffSet += proxQualFactor * ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.ButcheryFleshSpeedOffSet += proxQualFactor * ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxButcheryMechanoidSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.ButcheryMechanoidSpeedOffSet += proxQualFactor * ProximityGet.GetProxButcheryMechanoidSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxButcheryFleshEfficiencyOffSet(thing.def) != 0f)
                    {
                        proximityData.ButcheryFleshEfficiencyOffSet += proxQualFactor * ProximityGet.GetProxButcheryFleshEfficiencyOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxButcheryMechanoidEfficiencyOffSet(thing.def) != 0f)
                    {
                        proximityData.ButcheryMechanoidEfficiencyOffSet += proxQualFactor * ProximityGet.GetProxButcheryMechanoidEfficiencyOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxCookSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.CookSpeedOffSet += proxQualFactor * ProximityGet.GetProxCookSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.DrugCookingSpeedOffSet += proxQualFactor * ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.DrugSynthesisSpeedOffSet += proxQualFactor * ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxFixBrokenDownBuildingSuccessChanceOffSet(thing.def) != 0f)
                    {
                        proximityData.FixBrokenDownBuildingSuccessChanceOffSet += proxQualFactor * ProximityGet.GetProxFixBrokenDownBuildingSuccessChanceOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxSmeltingSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.SmeltingSpeedOffSet += proxQualFactor * ProximityGet.GetProxSmeltingSpeedOffSet(thing.def);
                    }
                    if (ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def) != 0f)
                    {
                        proximityData.GeneralLaborSpeedOffSet += proxQualFactor * ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def);
                    }
                }
            }
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003CE8 File Offset: 0x00001EE8
		internal static void ProximityTStatSet(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn)
		{
			ThingComp thingComp = pawn?.TryGetComp<ProximityData>();
			if (thingComp != null)
			{
                if (thingComp is ProximityData proximityData)
                {
                    float num = 1f;
                    if (ProximityGet.GetTProxMoveSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.MoveSpeedOffSet += num * ProximityGet.GetTProxMoveSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain) != 0f)
                    {
                        proximityData.GlobalLearningFactorOffSet += num * ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxNegotiationAbilityOffSet(terrain) != 0f)
                    {
                        proximityData.NegotiationAbilityOffSet += num * ProximityGet.GetTProxNegotiationAbilityOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxPsychicSensitivityOffSet(terrain) != 0f)
                    {
                        proximityData.PsychicSensitivityOffSet += num * ProximityGet.GetTProxPsychicSensitivityOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxSocialImpactOffSet(terrain) != 0f)
                    {
                        proximityData.SocialImpactOffSet += num * ProximityGet.GetTProxSocialImpactOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxToxicSensitivityOffSet(terrain) != 0f)
                    {
                        proximityData.ToxicSensitivityOffSet += num * ProximityGet.GetTProxToxicSensitivityOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain) != 0f)
                    {
                        proximityData.ComfyTemperatureMinOffSet += num * ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain) != 0f)
                    {
                        proximityData.ComfyTemperatureMaxOffSet += num * ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxAimingDelayFactorOffSet(terrain) != 0f)
                    {
                        proximityData.AimingDelayFactorOffSet += num * ProximityGet.GetTProxAimingDelayFactorOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain) != 0f)
                    {
                        proximityData.ShootingAccuracyPawnOffSet += num * ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain) != 0f)
                    {
                        proximityData.MeleeDodgeChanceOffSet += num * ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMeleeHitChanceOffSet(terrain) != 0f)
                    {
                        proximityData.MeleeHitChanceOffSet += num * ProximityGet.GetTProxMeleeHitChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.ImmunityGainSpeedOffSet += num * ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.MedicalTendSpeedOffSet += num * ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMedicalTendQualityOffSet(terrain) != 0f)
                    {
                        proximityData.MedicalTendQualityOffSet += num * ProximityGet.GetTProxMedicalTendQualityOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.MedicalOperationSpeedOffSet += num * ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain) != 0f)
                    {
                        proximityData.MedicalSurgerySuccessChanceOffSet += num * ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.AnimalGatherSpeedOffSet += num * ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain) != 0f)
                    {
                        proximityData.AnimalGatherYieldOffSet += num * ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxConstructionSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.ConstructionSpeedOffSet += num * ProximityGet.GetTProxConstructionSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain) != 0f)
                    {
                        proximityData.ConstructSuccessChanceOffSet += num * ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxEatingSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.EatingSpeedOffSet += num * ProximityGet.GetTProxEatingSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxHuntingStealthOffSet(terrain) != 0f)
                    {
                        proximityData.HuntingStealthOffSet += num * ProximityGet.GetTProxHuntingStealthOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxMiningSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.MiningSpeedOffSet += num * ProximityGet.GetTProxMiningSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain) != 0f)
                    {
                        proximityData.PlantHarvestYieldOffSet += num * ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.PlantWorkSpeedOffSet += num * ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxResearchSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.ResearchSpeedOffSet += num * ProximityGet.GetTProxResearchSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxSmoothingSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.SmoothingSpeedOffSet += num * ProximityGet.GetTProxSmoothingSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxTameAnimalChanceOffSet(terrain) != 0f)
                    {
                        proximityData.TameAnimalChanceOffSet += num * ProximityGet.GetTProxTameAnimalChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain) != 0f)
                    {
                        proximityData.TrainAnimalChanceOffSet += num * ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain) != 0f)
                    {
                        proximityData.WorkSpeedGlobalOffSet += num * ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.ButcheryFleshSpeedOffSet += num * ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.ButcheryMechanoidSpeedOffSet += num * ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain) != 0f)
                    {
                        proximityData.ButcheryFleshEfficiencyOffSet += num * ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain) != 0f)
                    {
                        proximityData.ButcheryMechanoidEfficiencyOffSet += num * ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxCookSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.CookSpeedOffSet += num * ProximityGet.GetTProxCookSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.DrugCookingSpeedOffSet += num * ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.DrugSynthesisSpeedOffSet += num * ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain) != 0f)
                    {
                        proximityData.FixBrokenDownBuildingSuccessChanceOffSet += num * ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxSmeltingSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.SmeltingSpeedOffSet += num * ProximityGet.GetTProxSmeltingSpeedOffSet(terrain);
                    }
                    if (ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain) != 0f)
                    {
                        proximityData.GeneralLaborSpeedOffSet += num * ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain);
                    }
                }
            }
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000042F4 File Offset: 0x000024F4
		internal static float GetProxData(Thing thing, int num)
		{
			float result = 0f;
			if (thing is Pawn)
			{
				ThingComp thingComp = thing?.TryGetComp<ProximityData>();
				if (thingComp != null)
				{
                    if (thingComp is ProximityData proximityData)
                    {
                        switch (num)
                        {
                            case 1:
                                return proximityData.MoveSpeedOffSet;
                            case 2:
                                return proximityData.GlobalLearningFactorOffSet;
                            case 3:
                                return proximityData.PsychicSensitivityOffSet;
                            case 4:
                                return proximityData.ToxicSensitivityOffSet;
                            case 9:
                                return proximityData.MeleeDodgeChanceOffSet;
                            case 10:
                                return proximityData.MeleeHitChanceOffSet;
                            case 11:
                                return proximityData.AnimalGatherSpeedOffSet;
                            case 12:
                                return proximityData.ConstructionSpeedOffSet;
                            case 13:
                                return proximityData.EatingSpeedOffSet;
                            case 14:
                                return proximityData.MiningSpeedOffSet;
                            case 15:
                                return proximityData.PlantWorkSpeedOffSet;
                            case 16:
                                return proximityData.SmoothingSpeedOffSet;
                            case 18:
                                return proximityData.WorkSpeedGlobalOffSet;
                            case 19:
                                return proximityData.ConstructSuccessChanceOffSet;
                            case 20:
                                return proximityData.PlantHarvestYieldOffSet;
                            case 21:
                                return proximityData.TameAnimalChanceOffSet;
                            case 22:
                                return proximityData.AimingDelayFactorOffSet;
                            case 23:
                                return proximityData.ImmunityGainSpeedOffSet;
                            case 24:
                                return proximityData.NegotiationAbilityOffSet;
                            case 25:
                                return proximityData.SocialImpactOffSet;
                            case 26:
                                return proximityData.TrainAnimalChanceOffSet;
                            case 27:
                                return proximityData.AnimalGatherYieldOffSet;
                            case 28:
                                return proximityData.ResearchSpeedOffSet;
                            case 29:
                                return proximityData.ShootingAccuracyPawnOffSet;
                            case 30:
                                return proximityData.HuntingStealthOffSet;
                            case 31:
                                return proximityData.FixBrokenDownBuildingSuccessChanceOffSet;
                            case 32:
                                return proximityData.MedicalTendSpeedOffSet;
                            case 33:
                                return proximityData.MedicalTendQualityOffSet;
                            case 34:
                                return proximityData.MedicalOperationSpeedOffSet;
                            case 35:
                                return proximityData.MedicalSurgerySuccessChanceOffSet;
                            case 36:
                                return proximityData.ButcheryFleshSpeedOffSet;
                            case 37:
                                return proximityData.ButcheryMechanoidSpeedOffSet;
                            case 38:
                                return proximityData.ButcheryFleshEfficiencyOffSet;
                            case 39:
                                return proximityData.ButcheryMechanoidEfficiencyOffSet;
                            case 40:
                                return proximityData.CookSpeedOffSet;
                            case 41:
                                return proximityData.DrugCookingSpeedOffSet;
                            case 42:
                                return proximityData.DrugSynthesisSpeedOffSet;
                            case 44:
                                return proximityData.SmeltingSpeedOffSet;
                            case 47:
                                return proximityData.ComfyTemperatureMinOffSet;
                            case 48:
                                return proximityData.ComfyTemperatureMaxOffSet;
                            case 49:
                                return proximityData.GeneralLaborSpeedOffSet;
                        }
                        result = 0f;
                    }
                }
			}
			return result;
		}

		// Token: 0x04000004 RID: 4
		public float MoveSpeedOffSet;

		// Token: 0x04000005 RID: 5
		public float GlobalLearningFactorOffSet;

		// Token: 0x04000006 RID: 6
		public float NegotiationAbilityOffSet;

		// Token: 0x04000007 RID: 7
		public float PsychicSensitivityOffSet;

		// Token: 0x04000008 RID: 8
		public float SocialImpactOffSet;

		// Token: 0x04000009 RID: 9
		public float ToxicSensitivityOffSet;

		// Token: 0x0400000A RID: 10
		public float ComfyTemperatureMinOffSet;

		// Token: 0x0400000B RID: 11
		public float ComfyTemperatureMaxOffSet;

		// Token: 0x0400000C RID: 12
		public float AimingDelayFactorOffSet;

		// Token: 0x0400000D RID: 13
		public float ShootingAccuracyPawnOffSet;

		// Token: 0x0400000E RID: 14
		public float MeleeDodgeChanceOffSet;

		// Token: 0x0400000F RID: 15
		public float MeleeHitChanceOffSet;

		// Token: 0x04000010 RID: 16
		public float ImmunityGainSpeedOffSet;

		// Token: 0x04000011 RID: 17
		public float MedicalTendSpeedOffSet;

		// Token: 0x04000012 RID: 18
		public float MedicalTendQualityOffSet;

		// Token: 0x04000013 RID: 19
		public float MedicalOperationSpeedOffSet;

		// Token: 0x04000014 RID: 20
		public float MedicalSurgerySuccessChanceOffSet;

		// Token: 0x04000015 RID: 21
		public float AnimalGatherSpeedOffSet;

		// Token: 0x04000016 RID: 22
		public float AnimalGatherYieldOffSet;

		// Token: 0x04000017 RID: 23
		public float ConstructionSpeedOffSet;

		// Token: 0x04000018 RID: 24
		public float ConstructSuccessChanceOffSet;

		// Token: 0x04000019 RID: 25
		public float EatingSpeedOffSet;

		// Token: 0x0400001A RID: 26
		public float HuntingStealthOffSet;

		// Token: 0x0400001B RID: 27
		public float MiningSpeedOffSet;

		// Token: 0x0400001C RID: 28
		public float PlantHarvestYieldOffSet;

		// Token: 0x0400001D RID: 29
		public float PlantWorkSpeedOffSet;

		// Token: 0x0400001E RID: 30
		public float SmoothingSpeedOffSet;

		// Token: 0x0400001F RID: 31
		public float ResearchSpeedOffSet;

		// Token: 0x04000020 RID: 32
		public float TameAnimalChanceOffSet;

		// Token: 0x04000021 RID: 33
		public float TrainAnimalChanceOffSet;

		// Token: 0x04000023 RID: 35
		public float WorkSpeedGlobalOffSet;

		// Token: 0x04000024 RID: 36
		public float ButcheryFleshSpeedOffSet;

		// Token: 0x04000025 RID: 37
		public float ButcheryMechanoidSpeedOffSet;

		// Token: 0x04000026 RID: 38
		public float ButcheryFleshEfficiencyOffSet;

		// Token: 0x04000027 RID: 39
		public float ButcheryMechanoidEfficiencyOffSet;

		// Token: 0x04000028 RID: 40
		public float CookSpeedOffSet;

		// Token: 0x04000029 RID: 41
		public float DrugCookingSpeedOffSet;

		// Token: 0x0400002A RID: 42
		public float DrugSynthesisSpeedOffSet;

		// Token: 0x0400002B RID: 43
		public float FixBrokenDownBuildingSuccessChanceOffSet;

		//// Token: 0x0400002C RID: 44
		//public float SculptingSpeedOffSet;

		// Token: 0x0400002D RID: 45
		public float SmeltingSpeedOffSet;

        // Token: 0x0400002C RID: 49
        public float GeneralLaborSpeedOffSet;

        // Token: 0x04000030 RID: 48
        public int ProxTick;
	}
}
