import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {FormControl, FormGroup} from "@angular/forms";
import {ApiService} from "../../../services/api.service";

@Component({
  selector: 'app-add-schedule',
  templateUrl: './add-schedule.component.html',
  styleUrls: ['./add-schedule.component.css']
})
export class AddScheduleComponent implements OnInit {

  classrooms;
  rooms;
  faculties;
  targetFaculty;

  public addScheduleForm: FormGroup;


  constructor(
      @Inject(MAT_DIALOG_DATA) private data: any,
      private dialogRef: MatDialogRef<AddScheduleComponent>,
      private apiService: ApiService
  ) { }

  ngOnInit(): void {
    this.classrooms = this.data?.classrooms;
    this.rooms = this.data?.rooms;
    this.faculties = this.data?.faculties;
    this.targetFaculty = this.data?.targetFaculty;
    this.addScheduleForm = new FormGroup({
      classroom: new FormControl(''),
      room: new FormControl(''),
      startTime: new FormControl(''),
      endTime: new FormControl(''),
      facultyId: new FormControl(this.targetFaculty?.id)
    })
  }

  submit() {
    const schedule = this.addScheduleForm.value;

    this.apiService.createSchedule(schedule).subscribe(data => {
      this.dialogRef.close(true);
    });

    console.log(this.addScheduleForm.value);
  }
}
