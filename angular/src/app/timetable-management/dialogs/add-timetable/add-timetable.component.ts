import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {ApiService} from "../../../services/api.service";
import {FormControl, FormGroup} from "@angular/forms";

@Component({
  selector: 'app-add-timetable',
  templateUrl: './add-timetable.component.html',
  styleUrls: ['./add-timetable.component.css']
})
export class AddTimetableComponent implements OnInit {
  addTimetableForm: FormGroup;
  subjects: any;
  teachers: any;

  constructor(
      @Inject(MAT_DIALOG_DATA) private data: any,
      private dialogRef: MatDialogRef<AddTimetableComponent>,
      private apiService: ApiService
  ) { }

  ngOnInit(): void {
    this.addTimetableForm = new FormGroup({
      subjectId: new FormControl(''),
      teacherId: new FormControl(''),
      stack: new FormControl(''),
      scheduleId: new FormControl(this.data?.scheduleId),
      dayIndex: new FormControl(this.data?.dayIndex)
    });

    this.subjects = this.data?.subjects;
    this.teachers = this.data?.teachers;
  }

  submit() {
    const timetable = this.addTimetableForm.value;
    this.apiService.createTimetable(timetable).subscribe(data => {
      this.dialogRef.close(true);
    })
  }
}
