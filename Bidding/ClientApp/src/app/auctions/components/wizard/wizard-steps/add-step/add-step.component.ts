// angular
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

// internal


@Component({
  selector: 'app-auction-add-add-wizard-step',
  templateUrl: './add-step.component.html'
})
export class AuctionAddAddWizardStepComponent implements OnInit {
  @Output() emitAddWizardStep = new EventEmitter<boolean>();

  /** Form what used in the template */
  addStepForm: FormGroup;

  submitted = false;

  /** Form error object */
  formErrors = {
    make: '',
    model: '',
    manufacturingDate: '',
    vehicleRegistrationNumber: '',
    vehicleIdentificationNumber: '',
    vehicleInspectionActive: '',
    power: '',
    engineSize: '',
    fuelType: '',
    transmission: '',
    gearbox: '',
    evaluation: ''
  };

  /** Convenience getter for easy access to form fields */
  get f() { return this.addStepForm.controls; }

  constructor(
    private fb: FormBuilder
  ) { }

  ngOnInit(): void {
    this.buildForm();
  }

  addWizardStep() {
    this.emitAddWizardStep.emit(true);
  }

  private buildForm(): void {
    this.addStepForm = this.fb.group({
      make: ['', []],
      model: ['', []],
      manufacturingDate: ['', []],
      vehicleRegistrationNumber: ['', []],
      vehicleIdentificationNumber: ['', []],
      vehicleInspectionActive: ['', []],
      power: ['', []],
      engineSize: ['', []],
      fuelType: ['', []],
      transmission: ['', []],
      gearbox: ['', []],
      evaluation: ['', []]
    });
  }
}