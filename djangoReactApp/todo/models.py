from django.db import models

class Todo(models.Model):
    name = models.CharField(max_length=100)
    due_dt = models.DateField()

    def __str__(self):
        return self.name
    